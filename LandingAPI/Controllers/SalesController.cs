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
        [HttpGet]
        public async Task<IActionResult> GetBuyerDetails(string search)
        {
            return Response(await _salesService.GetBuyerDetails(search));
        }
        [HttpPost]
        public async Task<IActionResult> AddBuyerDetails(AddBuyerDto buyerDto)
        {
            return Response(await _salesService.AddBuyerDetails(buyerDto));
        }
        [HttpPost]
        public async Task<IActionResult> AddUpdateLandLocation(UpdateLandCoordinateDto landCoordinateDto)
        {
            return Response(await _salesService.UpdateLandCoordinated(landCoordinateDto));
        }
        [HttpGet]
        public async Task<IActionResult> GetLandCoordinates(int landId)
        {
            return Response(await _salesService.GetLandCoordinates(landId));
        }
    }
}
