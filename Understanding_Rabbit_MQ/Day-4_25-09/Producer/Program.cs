using Producer.Exchanges;
using RabbitMQ.Client;

namespace Producer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost", VirtualHost = "/", UserName = "guest", Password = "guest" };

            Fanout_exchange FanoutExchange = new Fanout_exchange(factory);

            Console.WriteLine("Enter messages to send (type 'exit' to quit):");

            while (true)
            {
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;
                if (input.ToLower() == "exit") break;

                await FanoutExchange.SendMessage(input);


            }


        }
    }
}


