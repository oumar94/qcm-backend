using Microsoft.AspNetCore.Mvc;
using QcmBackend.Models;
using QcmBackend.Services;

namespace QcmBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QcmsController : ControllerBase
    {


        private readonly ILogger<QcmsController> _logger;
        private readonly IQcmService _service;

        public QcmsController(ILogger<QcmsController> logger, IQcmService service)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _service = service ?? throw new ArgumentNullException(nameof(service)); ;
        }

        [HttpGet("")]
        public ActionResult<ICollection<Qcm>> GetQcms()
        {
            var result = _service.GetQcms();
            return Ok(new { Qcms = result });
        }

        [HttpGet("{qcmId}")]
        public ActionResult<Qcm> GetQcmById(int qcmId)
        {
            var result = _service.GetQcmById(qcmId);
            if (result == null) return NotFound(new { Success = false, Message = $"no qcm was found for the id {qcmId}" });
            return Ok(result);
        }

        [HttpPost("")]
        public ActionResult<ICollection<Qcm>> CreateQcm([FromBody] QcmRequest request)
        {
            var result = _service.CreateQcm(request);
            return Created(string.Empty, result);
        }
    }
}