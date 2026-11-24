namespace CargoHub.Api.Models;

public class Item : IEntity
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public string ModelNumber { get; set; } = string.Empty;
    public int CommodityCode { get; set; }
    public double UnitWeight { get; set; }
    public int MinPurchaseQty { get; set; }
    public int CaseSize { get; set; }
    public string PackagingType { get; set; } = string.Empty;
    public int OrderMultiple { get; set; }
    public string SupplierSku { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public int ItemLineId { get; set; }
    public int ItemGroupId { get; set; }
    public int ItemTypeId { get; set; }
    public int SupplierId { get; set; }

    public ItemLine ItemLine { get; set; } = null!;
    public ItemGroup ItemGroup { get; set; } = null!;
    // public ItemType ItemType { get; set; } = null!;
    public Supplier Supplier { get; set; } = null!;
}