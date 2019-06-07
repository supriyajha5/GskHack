namespace WebHook.Models
{
    public class RootObject
    {
        public string event_id { get; set; }
        public string event_type { get; set; }
        public FormResponse form_response { get; set; }
    }
}