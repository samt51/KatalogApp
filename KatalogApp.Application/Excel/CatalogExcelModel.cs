namespace KatalogApp.Application.Excel;

public class CatalogExcelModel
{
    public string? Code { get; set; }
    public string? Barcode { get; set; }
    public string? BagNumber { get; set; }
    public string? Picture { get; set; }
    public string? Model { get; set; }
    public string? Description { get; set; }
    public double QtyPcs { get; set; }
    public double TotalWeight { get; set; }
    public double Carat { get; set; }
    public double FineGold { get; set; }
    public double FineGoldPrice { get; set; }
    public double TotalFineGoldPrice { get; set; }
    
    public double D1StoneSize { get; set; }
    public double D1StoneCt { get; set; }
    public double D1StoneCtPrice { get; set; }
    public double D1TotalPrice { get; set; }
    public double D1StonePcs { get; set; }
    public double D1StoneSettingPrice { get; set; }
    public double D1TotalSettingPrice { get; set; }
    
    public double D2StoneSize { get; set; }
    public double D2StoneCt { get; set; }
    public double D2StoneCtPrice { get; set; }
    public double D2TotalPrice { get; set; }
    public double D2StonePcs { get; set; }
    public double D2StoneSettingPrice { get; set; }
    public double D2TotalSettingPrice { get; set; }
    
    public double D3StoneSize { get; set; }
    public double D3StoneCt { get; set; }
    public double D3StoneCtPrice { get; set; }
    public double D3TotalPrice { get; set; }
    public double D3StonePcs { get; set; }
    public double D3StoneSettingPrice { get; set; }
    public double D3TotalSettingPrice { get; set; }
    
    public double LastPolishRodium { get; set; }
    public double Price { get; set; }
    public double Multiplier { get; set; }
    public double TotalPrice { get; set; }
}
