using Microsoft.Azure.Cosmos.Table;

namespace WebHook.Models
{
    public class SampleRequestEntity : TableEntity
    {
        public string Problem { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public string AgeRange { get; set; }
        public bool IsOptedIn { get; set; }
    }
}