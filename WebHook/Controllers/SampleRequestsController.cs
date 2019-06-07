using Microsoft.AspNetCore.Mvc;
using WebHook.Models;
using WebHook.Services;

namespace WebHook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleRequestsController : ControllerBase
    {
        private readonly ISampleRequestService _service;

        public SampleRequestsController(ISampleRequestService service)
        {
            _service = service;
        }

        // POST: api/samplerequests
        [HttpPost]
        public void Post([FromBody] FormData data)
        {
            var entity = data.ConvertToEntity();
            _service.Create(entity);
        }
    }
}