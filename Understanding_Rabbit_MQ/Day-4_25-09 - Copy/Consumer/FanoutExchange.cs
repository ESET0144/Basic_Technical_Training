


using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;



public class FanoutExchange
    {
        private readonly IChannel channel;

        private readonly string _exchangeName = "order.fanout";
        private readonly string _queueName = "q.order.update";
    private IConnection channel1;

    public FanoutExchange(IChannel channel)
        {
            channel = channel;
        }

    public FanoutExchange(IConnection channel1)
    {
        this.channel1 = channel1;
    }

    public async Task ConsumeMessage()
        {

            // Declare the fanout exchange and queue
            await channel.ExchangeDeclareAsync(exchange: _exchangeName, type: ExchangeType.Fanout);
            await channel.QueueDeclareAsync(queue: _queueName, exclusive: false, autoDelete: false);

            // Bind queue to exchange
            await channel.QueueBindAsync(queue: _queueName, exchange: _exchangeName, routingKey: string.Empty);

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($"[Fanout Exchange {_queueName}] Received: {message}");
                return Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(_queueName, autoAck: true, consumer: consumer);
        }
    }
