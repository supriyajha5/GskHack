using Microsoft.Azure.Cosmos.Table;

namespace WebHook.Models
{
    public sealed class FormData
    {
        public string event_id { get; set; }
        public string event_type { get; set; }
        public FormResponse form_response { get; set; }
    }
}