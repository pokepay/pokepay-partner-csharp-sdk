#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json;

namespace pokepay_partner_csharp_sdk
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new Client("config.ini");
            var sendEchoRequest = new SendEcho("message1");

            var echo = await sendEchoRequest.Send(client);

            Console.WriteLine("{0}", JsonSerializer.Serialize(echo));
        }
    }
}
