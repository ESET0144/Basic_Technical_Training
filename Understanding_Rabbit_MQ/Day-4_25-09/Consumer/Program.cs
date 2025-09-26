using Consumer;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Consumer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost", VirtualHost = "/", UserName = "guest", Password = "guest" };

            Fanout_exchange FanoutExchange = new Fanout_exchange();



            FanoutExchange.ConsumeMessage();

            
            Console.WriteLine(" Press [enter] to exit.");


        }
    }
}







