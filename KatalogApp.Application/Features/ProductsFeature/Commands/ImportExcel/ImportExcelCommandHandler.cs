using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Interfaces.Services;
using KatalogApp.Application.Common.Abstractions.Repositories;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Excel;
using KatalogApp.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.ProductsFeature.Commands.ImportExcel
{
    public class ImportExcelCommandHandler : IRequestHandler<ImportExcelCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IExchangeRateService _exchangeRateService;
        int COUNT;
        public ImportExcelCommandHandler(IUnitOfWork unitOfWork, IExchangeRateService exchangeRateService)
        {
            _unitOfWork = unitOfWork;
            _exchangeRateService = exchangeRateService;
        }

        public async Task<ResponseDto<bool>> Handle(ImportExcelCommandRequest request, CancellationToken cancellationToken)
        {
            var excelData = CatalogExcelData.Data;
            if (excelData == null || !excelData.Any())
                return new ResponseDto<bool> { isSuccess = true, data = true };
          
            decimal liveGoldPrice = await _exchangeRateService.GetHasAltinPriceAsync();

            var categoryRepo = _unitOfWork.GetWriteRepository<Category>();
            var colorRepo = _unitOfWork.GetWriteRepository<Colors>();
            var metalPurityRepo = _unitOfWork.GetWriteRepository<MetalPurity>();
            var stoneScaleRepo = _unitOfWork.GetWriteRepository<StoneScale>();
            var stoneSettingRepo = _unitOfWork.GetWriteRepository<StoneSetting>();
            var stoneRepo = _unitOfWork.GetWriteRepository<Stone>();
            var productRepo = _unitOfWork.GetWriteRepository<Products>();
            var stoneTypeRepo = _unitOfWork.GetWriteRepository<StoneType>();
            var metalTypeRepo = _unitOfWork.GetWriteRepository<MetalType>();

            await _unitOfWork.OpenTransactionAsync(cancellationToken);
            try
            {
                var categories = (await _unitOfWork.GetReadRepository<Category>().GetAllAsync(enableTracking: true)).ToDictionary(x => x.Name.ToLower());
                var colors = (await _unitOfWork.GetReadRepository<Colors>().GetAllAsync(enableTracking: true)).ToDictionary(x => x.Name.ToLower());
                var metalPurities = (await _unitOfWork.GetReadRepository<MetalPurity>().GetAllAsync(enableTracking: true)).ToList();
                var units = await _unitOfWork.GetReadRepository<Units>().GetAllAsync(enableTracking: true);
                var stoneScales = (await _unitOfWork.GetReadRepository<StoneScale>().GetAllAsync(enableTracking: true)).ToDictionary(x => x.Name.ToLower());
                var stoneSettings = (await _unitOfWork.GetReadRepository<StoneSetting>().GetAllAsync(enableTracking: true)).ToList();
                var stones = (await _unitOfWork.GetReadRepository<Stone>().GetAllAsync(enableTracking: true)).ToList();
                
                var pieceUnit = units.FirstOrDefault(u => u.Name.ToLower().Contains("adet") || u.Name.ToLower() == "piece");
                if (pieceUnit == null)
                {
                    pieceUnit = new Units { Name = "Adet" };
                    await _unitOfWork.GetWriteRepository<Units>().AddAsync(pieceUnit);
                    await _unitOfWork.SaveAsync(cancellationToken);
                }

                var ctUnit = units.FirstOrDefault(u => u.Name.ToLower() == "ct");
                if (ctUnit == null)
                {
                    ctUnit = new Units { Name = "Ct" };
                    await _unitOfWork.GetWriteRepository<Units>().AddAsync(ctUnit);
                    await _unitOfWork.SaveAsync(cancellationToken);
                }

                var stoneTypes = await _unitOfWork.GetReadRepository<StoneType>().GetAllAsync(enableTracking: true);
                var stoneType = stoneTypes.FirstOrDefault();
                if (stoneType == null)
                {
                    stoneType = new StoneType { Name = "Pırlanta" };
                    await stoneTypeRepo.AddAsync(stoneType);
                    await _unitOfWork.SaveAsync(cancellationToken);
                }

                var metalTypesList = (await _unitOfWork.GetReadRepository<MetalType>().GetAllAsync(enableTracking: true)).ToList();

                if (!colors.TryGetValue("d", out var colorD))
                {
                    colorD = new Colors { Name = "D" };
                    await colorRepo.AddAsync(colorD);
                    await _unitOfWork.SaveAsync(cancellationToken);
                    colors["d"] = colorD;
                }

                foreach (var row in excelData)
                {
                  
                    Category category = null;
                    if (!string.IsNullOrWhiteSpace(row.Model))
                    {
                        var catName = GetTurkishCategoryName(row.Model.Trim());
                        if (!categories.TryGetValue(catName.ToLower(), out category))
                        {
                            category = new Category { Name = catName };
                            await categoryRepo.AddAsync(category);
                            await _unitOfWork.SaveAsync(cancellationToken);
                            categories[catName.ToLower()] = category;
                        }
                    }

                    MetalPurity metalPurity = null;
                    if (row.Carat > 0)
                    {
                        decimal targetMilyem = (decimal)row.Carat;
                        metalPurity = metalPurities.FirstOrDefault(x => x.Milyem == targetMilyem);
                        
                        if (metalPurity == null)
                        {
                            string purityName = targetMilyem == 0.75m ? "18K" : (targetMilyem == 0.585m || targetMilyem == 0.59m ? "14K" : $"{targetMilyem}");
                            metalPurity = new MetalPurity { Name = purityName, Milyem = targetMilyem };
                            await metalPurityRepo.AddAsync(metalPurity);
                            await _unitOfWork.SaveAsync(cancellationToken);
                            metalPurities.Add(metalPurity);
                        }
                    }

                    MetalType rowMetalType = null;
                    if (!string.IsNullOrWhiteSpace(row.Description))
                    {
                        var desc = row.Description.Trim().ToUpper();
                        string targetMetalTypeName = desc;

                        if (desc == "1W") targetMetalTypeName = "Beyaz Altın";
                        else if (desc == "1Y" || desc == "1") targetMetalTypeName = "Altın"; // DB'deki 1 ID'li Sarı Altın
                        else if (desc == "1R" || desc == "1P") targetMetalTypeName = "Rose Altın";

                        rowMetalType = metalTypesList.FirstOrDefault(m => m.Name.Equals(targetMetalTypeName, System.StringComparison.OrdinalIgnoreCase));
                        if (rowMetalType == null)
                        {
                            rowMetalType = new MetalType { Name = targetMetalTypeName };
                            await metalTypeRepo.AddAsync(rowMetalType);
                            await _unitOfWork.SaveAsync(cancellationToken);
                            metalTypesList.Add(rowMetalType);
                        }
                    }
                    else
                    {
                        rowMetalType = metalTypesList.FirstOrDefault(m => m.Name == "Altın");
                        if (rowMetalType == null)
                        {
                            rowMetalType = new MetalType { Name = "Altın" };
                            await metalTypeRepo.AddAsync(rowMetalType);
                            await _unitOfWork.SaveAsync(cancellationToken);
                            metalTypesList.Add(rowMetalType);
                        }
                    }

                    decimal goldCost = metalPurity != null ? (decimal)row.TotalWeight * metalPurity.Milyem * liveGoldPrice : 0m;
                    decimal stoneCost = (decimal)(
                        (row.D1StoneCt * row.D1StoneCtPrice) +
                        (row.D2StoneCt * row.D2StoneCtPrice) +
                        (row.D3StoneCt * row.D3StoneCtPrice));
                    
                    decimal settingCost = (decimal)(
                        (row.D1StonePcs * row.D1StoneSettingPrice) +
                        (row.D2StonePcs * row.D2StoneSettingPrice) +
                        (row.D3StonePcs * row.D3StoneSettingPrice));
                    
                    decimal polishCost = (decimal)row.LastPolishRodium;
                    decimal totalCost = goldCost + stoneCost + settingCost + polishCost;

                    string rawCode = row.Code ?? "UNKNOWN";
                    string cleanCode = rawCode.Replace("DGF26", "");

                    var product = new Products
                    {
                        Code = cleanCode,
                        Name = cleanCode,
                        Description = row.Description ?? "",
                        Gram = (decimal)row.TotalWeight,
                        MetalPurityId = metalPurity?.Id,
                        PolishingCost = polishCost,
                        LiveGoldPrice = liveGoldPrice,
                        LaborMultiplier = 0m,
                        ImageName = row.Picture ?? "",
                        GoldCost = goldCost,
                        LaborCost = 0m,
                        StoneCost = stoneCost,
                        SettingCost = settingCost,
                        TotalCost = totalCost
                    };

                    if (category != null)
                    {
                        var trackedCat = await _unitOfWork.GetReadRepository<Category>().FindAsync(c => c.Id == category.Id, enableTracking: true);
                        if (trackedCat != null)
                        {
                            product.Categories.Add(trackedCat);
                        }
                        else
                        {
                            product.Categories.Add(category);
                        }
                    }

                    var d1 = await ProcessStone(row.D1StoneSize, row.D1StoneSettingPrice, row.D1StoneCtPrice, row.D1StonePcs, row.D1StoneCt, 
                        stoneScaleRepo, stoneSettingRepo, stoneRepo, pieceUnit, ctUnit, stoneType, stoneScales, stoneSettings, stones, colorD, cancellationToken);
                    if (d1 != null) product.ProductStones.Add(d1);

                    var d2 = await ProcessStone(row.D2StoneSize, row.D2StoneSettingPrice, row.D2StoneCtPrice, row.D2StonePcs, row.D2StoneCt, 
                        stoneScaleRepo, stoneSettingRepo, stoneRepo, pieceUnit, ctUnit, stoneType, stoneScales, stoneSettings, stones, colorD, cancellationToken);
                    if (d2 != null) product.ProductStones.Add(d2);

                    var d3 = await ProcessStone(row.D3StoneSize, row.D3StoneSettingPrice, row.D3StoneCtPrice, row.D3StonePcs, row.D3StoneCt, 
                        stoneScaleRepo, stoneSettingRepo, stoneRepo, pieceUnit, ctUnit, stoneType, stoneScales, stoneSettings, stones, colorD, cancellationToken);
                    if (d3 != null) product.ProductStones.Add(d3);

                    if (metalPurity != null && rowMetalType != null)
                    {
                        product.ProductMetals.Add(new ProductMetal
                        {
                            Weight = (decimal)row.TotalWeight,
                            MetalTypeId = rowMetalType.Id,
                            MetalPurityId = metalPurity.Id
                        });
                    }

                    product.DiamondCarat = product.ProductStones.Sum(s => s.TotalCarat);
                    
                    await productRepo.AddAsync(product);
                    COUNT++;
                }

                await _unitOfWork.SaveAsync(cancellationToken);
                await _unitOfWork.CommitAsync(cancellationToken);
                return new ResponseDto<bool> { isSuccess = true, data = true };
            }
            catch (System.Exception)
            {
                await _unitOfWork.RollBackAsync(cancellationToken);
                throw;
            }
        }

        private async Task<ProductStone> ProcessStone(
            double size, double settingPrice, double costPrice, double quantity, double totalCarat,
            IWriteRepository<StoneScale> scaleRepo, IWriteRepository<StoneSetting> settingRepo, IWriteRepository<Stone> stoneRepo,
            Units pieceUnit, Units ctUnit, StoneType stoneType, Dictionary<string, StoneScale> scaleMap, List<StoneSetting> settings, List<Stone> stones, Colors colorD, CancellationToken ct)
        {
            if (quantity <= 0 && totalCarat <= 0) return null;

            string scaleName = GetStoneScaleName(size);
            if (!scaleMap.TryGetValue(scaleName.ToLower(), out var scale))
            {
                scale = new StoneScale { Name = scaleName };
                await scaleRepo.AddAsync(scale);
                await _unitOfWork.SaveAsync(ct);
                scaleMap[scaleName.ToLower()] = scale;
            }

            var setting = settings.FirstOrDefault(s => s.SettingPrice == (decimal)settingPrice && s.UnitId == pieceUnit.Id);
            if (setting == null)
            {
                setting = new StoneSetting { SettingPrice = (decimal)settingPrice, UnitId = pieceUnit.Id };
                await settingRepo.AddAsync(setting);
                await _unitOfWork.SaveAsync(ct);
                settings.Add(setting);
            }

            var stone = stones.FirstOrDefault(s => s.StoneScaleId == scale.Id && s.StoneSettingId == setting.Id && s.CostPrice == (decimal)costPrice && s.UnitId == ctUnit.Id);
            if (stone == null)
            {
                stone = new Stone
                {
                    StoneScaleId = scale.Id,
                    StoneSettingId = setting.Id,
                    CostPrice = (decimal)costPrice,
                    StoneTypeId = stoneType.Id,
                    UnitId = ctUnit.Id
                };
                
                await stoneRepo.AddAsync(stone);
                await _unitOfWork.SaveAsync(ct);
                stones.Add(stone);
            }

            return new ProductStone
            {
                StoneId = stone.Id,
                Quantity = (int)quantity,
                TotalCarat = (decimal)totalCarat,
                ColorId = colorD?.Id,
                ClarityId = 1
            };
        }

        private string GetStoneScaleName(double size)
        {
            if (size > 0 && size <= 0.022) return "-6,5";
            if (size > 0.022 && size <= 0.07) return "+6,5";
            if (size > 0.07 && size <= 0.13) return "+11";
            if (size > 0.13 && size <= 0.17) return "+15";
            if (size > 0.17 && size <= 0.22) return "+20";
            if (size > 0.22 && size <= 0.25) return "+25";
            if (size > 0.25 && size <= 0.30) return "+30";
            
            // 0.30'dan büyükse veya aralık dışındaysa direkt stringini dön
            return size.ToString();
        }

        private string GetTurkishCategoryName(string englishName)
        {
            if (string.IsNullOrWhiteSpace(englishName)) return englishName;
            
            var upper = englishName.ToUpperInvariant();
            if (upper.Contains("RING") && !upper.Contains("EARRING")) return "YÜZÜK";
            if (upper == "1") return "YÜZÜK";
            if (upper.Contains("EARRING")) return "KÜPE";
            if (upper.Contains("NECKLACE") || upper.Contains("NEACKLACE") || upper.Contains("PENDANT")) return "KOLYE";
            if (upper.Contains("BRACELET") || upper.Contains("BRACLET") || upper.Contains("BRACLETE") || upper.Contains("ŞAHMERAN") || upper.Contains("SAHMERAN")) return "BİLEKLİK";
            if (upper.Contains("BANGLE")) return "KELEPÇE";
            if (upper.Contains("SET")) return "SET";
            
            // Eğer eşleşme yoksa tamamen BÜYÜK HARF olarak kendisini döndür
            return englishName.ToUpper(new System.Globalization.CultureInfo("tr-TR"));
        }
    }
}
