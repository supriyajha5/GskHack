using System;
using System.Collections.Generic;

namespace WebHook.Models
{
    public class FormResponse
    {
        public string form_id { get; set; }
        public string token { get; set; }
        public DateTime landed_at { get; set; }
        public DateTime submitted_at { get; set; }
        public Definition definition { get; set; }
        public List<Answer> answers { get; set; }
    }
}