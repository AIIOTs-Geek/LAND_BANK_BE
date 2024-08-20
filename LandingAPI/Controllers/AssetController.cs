using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace LandingAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class AssetController : BaseController
    {
        private readonly IAssetService _assetService;
        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetStatus(string statusType)
        {
            return Response(await _assetService.GetStatus(statusType));
        }
    }
}
