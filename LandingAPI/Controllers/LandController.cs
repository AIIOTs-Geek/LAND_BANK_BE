using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace LandingAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LandController : BaseController
    {
        private readonly ILandService _landService;
        public LandController(ILandService landService)
        {
            _landService = landService;
        }
        [HttpGet]
        public async Task<IActionResult> GetLandDetails(int landId, string? deptt)
        {
            return Response(await _landService.GetLandDetails(landId, deptt));
        }
    }
}
