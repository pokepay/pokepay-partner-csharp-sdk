#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Example
{
    public class MainProgram
    {
        static async Task Main(string[] args)
        {
            var client = new Client("config.ini");
            var sendEchoRequest = new Request.SendEcho("message1");

            var echo = await sendEchoRequest.Send(client);

            Console.WriteLine("{0}", JsonSerializer.Serialize(echo));
        }
    }
}
