using System.IO;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WebHook.Models;

namespace WebHook.Tests
{
    [TestClass]
    public class SampleRequestMapperTest
    {
        [TestMethod]
        public void TestMap()
        {
            var data = File.ReadAllText("data.json");
            var form = JsonConvert.DeserializeObject<FormData>(data);

            Assert.IsNotNull(form);

            var entity = form.ConvertToEntity();

            Assert.IsNotNull(entity);
            Assert.IsNotNull(entity.PartitionKey);
            Assert.IsNotNull(entity.RowKey);
            Assert.IsNotNull(entity.Problem);
            Assert.IsNotNull(entity.LastName);
            Assert.IsNotNull(entity.FirstName);
            Assert.IsNotNull(entity.Address);
            Assert.IsNotNull(entity.City);
            Assert.IsNotNull(entity.State);
            Assert.AreNotEqual(0, entity.Zip);
            Assert.IsNotNull(entity.AgeRange);
            Assert.IsTrue(entity.IsOptedIn);
        }
    }
}
