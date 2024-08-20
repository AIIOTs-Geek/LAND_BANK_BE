//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace DataContext.Migrations
//{
//    /// <inheritdoc />
//    public partial class TablesAdded : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "AssetMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    AssetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AssetMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "BusinessPlanMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    BusinessPlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_BusinessPlanMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "BusinessPlanStatusMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    BusinessPlanStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_BusinessPlanStatusMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "CityMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    CityId = table.Column<int>(type: "int", nullable: false),
//                    RegionId = table.Column<int>(type: "int", nullable: false),
//                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_CityMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "DistrictMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    DistrictId = table.Column<int>(type: "int", nullable: false),
//                    CityId = table.Column<int>(type: "int", nullable: false),
//                    RegionId = table.Column<int>(type: "int", nullable: false),
//                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_DistrictMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "LandMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    LandInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    DistrictId = table.Column<int>(type: "int", nullable: false),
//                    Area = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
//                    SubAssetId = table.Column<int>(type: "int", nullable: false),
//                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    LandUseId = table.Column<int>(type: "int", nullable: false),
//                    BusinessPlanDetailed = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    LandStatusId = table.Column<int>(type: "int", nullable: false),
//                    LandTypeId = table.Column<int>(type: "int", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_LandMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "LandStatusMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    LandStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_LandStatusMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "LandTypeMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    LandType = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    ParentId = table.Column<int>(type: "int", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_LandTypeMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "LandUseMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    LandUse = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    ParentId = table.Column<int>(type: "int", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_LandUseMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "RegionMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    RegionId = table.Column<int>(type: "int", nullable: false),
//                    CapitalCityId = table.Column<int>(type: "int", nullable: false),
//                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_RegionMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "SubAssetMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    SubAssetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    SubAssetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_SubAssetMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "WF_ActionMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_WF_ActionMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "WF_ControlMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    CurrentStage = table.Column<int>(type: "int", nullable: false),
//                    ActionId = table.Column<int>(type: "int", nullable: false),
//                    NextStage = table.Column<int>(type: "int", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_WF_ControlMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "WF_InstanceMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    InstanceId = table.Column<int>(type: "int", nullable: false),
//                    CurrentStageId = table.Column<int>(type: "int", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_WF_InstanceMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "WF_ProcessMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    ProcessNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    ProcessNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_WF_ProcessMaster", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "WF_StageMaster",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    ProcessId = table.Column<int>(type: "int", nullable: false),
//                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedBy = table.Column<int>(type: "int", nullable: false),
//                    CreatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IsActive = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_WF_StageMaster", x => x.Id);
//                });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "AssetMaster");

//            migrationBuilder.DropTable(
//                name: "BusinessPlanMaster");

//            migrationBuilder.DropTable(
//                name: "BusinessPlanStatusMaster");

//            migrationBuilder.DropTable(
//                name: "CityMaster");

//            migrationBuilder.DropTable(
//                name: "DistrictMaster");

//            migrationBuilder.DropTable(
//                name: "LandMaster");

//            migrationBuilder.DropTable(
//                name: "LandStatusMaster");

//            migrationBuilder.DropTable(
//                name: "LandTypeMaster");

//            migrationBuilder.DropTable(
//                name: "LandUseMaster");

//            migrationBuilder.DropTable(
//                name: "RegionMaster");

//            migrationBuilder.DropTable(
//                name: "SubAssetMaster");

//            migrationBuilder.DropTable(
//                name: "WF_ActionMaster");

//            migrationBuilder.DropTable(
//                name: "WF_ControlMaster");

//            migrationBuilder.DropTable(
//                name: "WF_InstanceMaster");

//            migrationBuilder.DropTable(
//                name: "WF_ProcessMaster");

//            migrationBuilder.DropTable(
//                name: "WF_StageMaster");
//        }
//    }
//}
