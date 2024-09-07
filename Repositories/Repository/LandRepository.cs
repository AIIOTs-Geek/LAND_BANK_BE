using Common.Dtos;
using Common.ViewModels;
using DataContext.DataClasses;
using Microsoft.Extensions.Configuration;
using Models.Models.UserDetails;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class LandRepository : ILandRepository
    {
        private readonly IConfiguration _configuration;
        public LandRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<GetLandDetailsFiltersResult?> GetLandDetails(int landId, string? deptt)
        {
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = db.GetLandDetailsFilters(landId, deptt, userId).SingleOrDefault();
                if (result == null)
                {
                    return null;
                }

                return result;
            }
        }
        public async Task<List<GetLandByAssetIdResult>> GetLandsByAssetId(int assetId, string? searchText, int? cityId, int? districtId, int? ownerId, int? landUseId, int? businessPlanId, int? IsWlt)
        {
            var result = new List<GetLandByAssetIdResult>();
            int? userId = null;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.GetLandByAssetId(assetId, searchText, cityId, districtId, ownerId, landUseId, businessPlanId, IsWlt, userId).ToList();

                if (result == null || !result.Any())
                {
                    return null;
                }
            }
            return result;
        }        
        public async Task<int> Updateland(UpdateLandDto landDto)
        {
            int? userId = null;
            int result;
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
                result = db.UpdateLandOverview(landDto.LandId, landDto.ActionName, userId, landDto.LandInfo, landDto.DistrictId, landDto.Area, landDto.SubAssetId, landDto.Location, landDto.MapUrl, landDto.BusinessPlanId, landDto.BusinessPlanDetailedId, landDto.BusinessPlanStatusId, landDto.LandStatusId, landDto.LandUseId, landDto.LandTypeId, landDto.WltStatus, landDto.MunHandingOver, landDto.MasterPlan, landDto.InfraApproval, landDto.InfraContraction, landDto.TitleDeedId, landDto.DeedNumber, landDto.DeedDate, landDto.DeedType, landDto.DeedStatus, landDto.DeedUrl, landDto.DeedOwner, landDto.DeedSequence);

                if (result != 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        public async Task<int> UpdateBuyerDetails(AddBuyerDto buyerDto)
        {
            int? userId = null;
            
            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
            {
               
                var result = db.UpsertBuyerDetails( userId,buyerDto.Id,buyerDto.BuyerId,buyerDto.BuyerName,buyerDto.CompanyId,buyerDto.BuyerEmail,buyerDto.BuyerMobile);
                if (result == null)
                {
                    return 0;
                }
                return 1;
            }
            
        }

        //public async Task<int> UpsertFinance(UpsertFinanceDto upsertFinance)
        //{
        //    int? userId = null;

        //    using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
        //    {

        //        var result = db.UpsertFinance(upsertFinance.LandId,upsertFinance.Value,upsertFinance.Date,upsertFinance.ValuationConsultantId,upsertFinance.TypeId,userId);
        //        if (result == -1)
        //        {

        //            return -1;
        //        }


        //        return 1;
        //    }

        //}

        public async Task<int> UpsertFinance(UpsertFinanceDto upsertFinance)
        {
            int? userId = null;
            string typeIds = null;
            string values = null;

            if (upsertFinance.TypeIds != null && upsertFinance.TypeIds.Any() &&
                   upsertFinance.Value != null && upsertFinance.Value.Any())
            {

                typeIds = string.Join(",", upsertFinance.TypeIds);
                 values = string.Join(",", upsertFinance.Value.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)));
            }

            using (var db = new PrDataClassesDataContext(_configuration.GetConnectionString("DefaultConnection")))
                {
                    
                    var result = db.UpsertFinance(
                        upsertFinance.LandId,
                        values,
                        upsertFinance.Date,
                        upsertFinance.ValuationConsultantId,  
                        userId,
                        typeIds,
                        upsertFinance.ZakatPayment,
                        upsertFinance.ZakatImplication
                    );

                    if (result == 1)
                    {
                        return 1;
                    }

                    return 0;
                }
            }
           
        
       

    }
}
