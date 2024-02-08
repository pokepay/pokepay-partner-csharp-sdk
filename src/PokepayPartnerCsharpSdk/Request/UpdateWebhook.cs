// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class UpdateWebhook
    {
        private string WebhookId { get; set; }
#if NETFRAMEWORK
        public string Url { get; set; }
        public System.Nullable<bool> IsActive { get; set; }
        public string Task { get; set; }
#else
        #nullable enable
        public string? Url { get; set; }
        #nullable enable
        public bool? IsActive { get; set; }
        #nullable enable
        public string? Task { get; set; }
#endif

        public UpdateWebhook(string webhookId) =>
            (WebhookId) = (webhookId);

        private string path { get { return "/webhooks" + "/" + WebhookId; } }

        private static readonly HttpMethod method = new HttpMethod("PATCH");

#if NETFRAMEWORK
        public async Task<OrganizationWorkerTaskWebhook> Send(Client client) {
                string res = await client.Send(path, UpdateWebhook.method, this);
                return JsonSerializer.Deserialize<OrganizationWorkerTaskWebhook>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<OrganizationWorkerTaskWebhook?> Send(Client client) {
                string res = await client.Send(path, UpdateWebhook.method, this);
                return JsonSerializer.Deserialize<OrganizationWorkerTaskWebhook>(res, client.JsonOptions);
        }
#endif
    }
}
