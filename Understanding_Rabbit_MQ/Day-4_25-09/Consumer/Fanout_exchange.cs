using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    internal class Fanout_exchange
    {

        public async Task ConsumeMessage()
        {
            var factory = new ConnectionFactory() { HostName = "localhost", VirtualHost = "/", UserName = "guest", Password = "guest" };

            string _exchangeName = "order.direct";

            string queueName = "q.create_order";
            using var connection = await factory.CreateConnectionAsync();


            using var channel = await connection.CreateChannelAsync();

            await channel.ExchangeDeclareAsync(exchange: _exchangeName, type: ExchangeType.Direct);
            await channel.QueueDeclareAsync(queue: queueName, durable: false, exclusive: false, autoDelete: false);

            // Bind queue to exchange with routing key
            await channel.QueueBindAsync(queue: queueName, exchange: _exchangeName, routingKey: string.Empty);

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($"[Direct Exchange {queueName}] Received: {message}");
                return Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(queueName, autoAck: true, consumer: consumer);
        }
    }
}
