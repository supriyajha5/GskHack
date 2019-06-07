using Newtonsoft.Json;

namespace WebHook.Models
{
    public class Choice
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}