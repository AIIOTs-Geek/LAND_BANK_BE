using Api.Controllers;
using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using Services.Service;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SalesController : BaseController
    {
        private readonly ISalesService _salesService;   
        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }
        [HttpPost]
        public async Task<IActionResult> AddUpdateLandLocation(UpdateLandCoordinateDto landCoordinateDto)
        {
            return Response(await _salesService.UpdateLandCoordinated(landCoordinateDto));
        }
    }
}
