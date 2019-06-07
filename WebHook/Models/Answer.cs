namespace WebHook.Models
{
    public class Answer
    {
        public string type { get; set; }
        public Choice choice { get; set; }
        public FieldReference field { get; set; }
        public bool? boolean { get; set; }
        public string text { get; set; }
        public string email { get; set; }
        public int? number { get; set; }
    }
}