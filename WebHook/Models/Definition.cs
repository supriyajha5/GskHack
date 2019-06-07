using System.Collections.Generic;

namespace WebHook.Models
{
    public class Definition
    {
        public string id { get; set; }
        public string title { get; set; }
        public List<FieldDefinition> fields { get; set; }
    }
}