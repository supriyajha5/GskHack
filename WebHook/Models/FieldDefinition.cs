using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WebHook.Models
{
    public class FieldDefinition
    {
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string @ref { get; set; }
        public PropertiesCollection properties { get; set; }
        public IList<ChoiceItem> choices { get; set; }
    }
}