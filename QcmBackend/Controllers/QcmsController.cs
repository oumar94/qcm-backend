using Microsoft.AspNetCore.Mvc;
using QcmBackend.Models;

namespace QcmBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QcmsController : ControllerBase
    {
        

        private readonly ILogger<QcmsController> _logger;

        public QcmsController(ILogger<QcmsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult<ICollection<Qcm>> GetQcms()
        {
            return Ok(new Qcm());
        }

        [HttpPost("")]
        public ActionResult<ICollection<Qcm>> CreateQcm([FromBody] QcmRequest request)
        {
            return Ok(new Qcm());
        }
    }
}
