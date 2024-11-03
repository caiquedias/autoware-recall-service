using Autoware.Recall.Api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autoware.Recall.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecallController : ControllerBase
    {
        private readonly IChassiRecallApplicationService _chassiRecallApplicationService;

        public RecallController(IChassiRecallApplicationService chassiRecallApplicationService)
        {
            _chassiRecallApplicationService = chassiRecallApplicationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _chassiRecallApplicationService.GetChassiRecall();

                return Ok(result.ToList());
            }
            catch
            {
                throw;
            }
        }

        [HttpGet("{chassi}")]
        public IActionResult GetAllByChassi(string chassi)
        {
            try
            {
                var result = _chassiRecallApplicationService.GetChassiRecallByChassi(chassi);

                return Ok(result.ToList());
            }
            catch
            {
                throw;
            }
        }
    }
}
