using Api.Controllers;
using Common.Dtos;
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

        [HttpGet]
        public async Task<IActionResult> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? userId, int? landUseId, int? businessPlanId, int? IsWlt)
        {
            return Response(await _landService.GetLandsByAssetId(assetId, searchText, cityId, districtId, userId, landUseId, businessPlanId, IsWlt));
        }
        [HttpGet]
        public async Task<IActionResult> GetBuyerDetails(string search)
        {
            return Response(await _landService.GetBuyerDetails(search));
        }
        [HttpPost]
        public async Task<IActionResult> AddBuyerDetails(AddBuyerDto buyerDto)
        {
            return Response(await _landService.AddBuyerDetails(buyerDto));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateLandOverview(UpdateLandDto landDto)
        {
            return Response(await _landService.UpdateLand(landDto));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBuyerDetails(AddBuyerDto buyerDto)
        {
            return Response(await _landService.UpdateBuyerDetails(buyerDto));
        }

    }
}
