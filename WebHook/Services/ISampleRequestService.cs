using Microsoft.Azure.Cosmos.Table;
using WebHook.Models;

namespace WebHook.Services
{
    public interface ISampleRequestService
    {
        //void Create(string data);
        void Create(TableEntity data);
    }
}