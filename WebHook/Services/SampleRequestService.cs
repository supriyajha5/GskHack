using System;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;

namespace WebHook.Services
{
    public class SampleRequestService : ISampleRequestService
    {
        private readonly IConfiguration _configuration;
        private CloudTableClient _tableClient;

        public SampleRequestService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Create(TableEntity data)
        {
            CreateStorageClient();

            var table = _tableClient.GetTableReference("samplerequests");

            table.ExecuteAsync(TableOperation.Insert(data));
        }

        public void CreateStorageClient()
        {
            if (_tableClient != null) return;

            try
            {
                var storageConnectionString = _configuration.GetValue<string>("StorageConnectionString");
                var storageAccount = CloudStorageAccount.Parse(storageConnectionString);
                _tableClient = storageAccount.CreateCloudTableClient(new TableClientConfiguration());
            }
            catch (ArgumentException ex)
            {
                throw new ApplicationException("Invalid storage account information provided.", ex);
            }
            catch (FormatException ex)
            {
                throw new ApplicationException("Invalid storage account information provided.", ex);
            }
        }
    }
}