namespace WebHook.Models
{
    public static class SampleRequestMapper
    {
        public static SampleRequestEntity ConvertToEntity(this FormData data)
        {
            var entity = new SampleRequestEntity
            {
                PartitionKey = data.form_response.form_id,
                RowKey = data.event_id
            };

            foreach (var answer in data.form_response.answers)
            {
                if (answer.field.id == "S1uW6phwIEgV" && answer.type == "choice")
                {
                    entity.Problem = answer.choice.Label;
                }
                else if (answer.field.id == "coytmnY7bllT" && answer.type == "text")
                {
                    entity.FirstName = answer.text;
                }
                else if (answer.field.id == "ApTwY6sHWU2A" && answer.type == "text")
                {
                    entity.LastName = answer.text;
                }
                else if (answer.field.id == "dWqgglT3OObB" && answer.type == "email")
                {
                    entity.Email = answer.email;
                }
                else if (answer.field.id == "RsX8ZRKf43TF" && answer.type == "text")
                {
                    entity.Address = answer.text;
                }
                else if (answer.field.id == "appTknC2sEoK" && answer.type == "text")
                {
                    entity.City = answer.text;
                }
                else if (answer.field.id == "RG0MIdswVznJ" && answer.type == "text")
                {
                    entity.State = answer.text;
                }
                else if (answer.field.id == "rerRUgmMu1u1" && answer.type == "number")
                {
                    entity.Zip = answer.number.GetValueOrDefault();
                }
                else if (answer.field.id == "W1SyR6Dx5EV1" && answer.type == "choice")
                {
                    entity.AgeRange = answer.choice.Label;
                }
                else if (answer.field.id == "K92zQSFLhW5H" && answer.type == "boolean")
                {
                    entity.IsOptedIn = answer.boolean.GetValueOrDefault();
                }
            }

            return entity;
        }
    }
}