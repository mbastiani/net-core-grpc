using Grpc.Net.Client;
using Grpc.Proto;
using System;
using System.Threading.Tasks;

namespace Grpc.Client
{
    internal static class Program
    {
        private static async Task Main()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Zé", Document="12345", Phone="1499999999"  });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
