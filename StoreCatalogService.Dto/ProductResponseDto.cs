namespace StoreCatalogService.Dto;

public class ProductResponseDto
{
    public string? StoreName { get; set; }
    public Guid ProductionId { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }
    public IList<Item>? Items { get; set; }
    public string? Price { get; set; }

    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
    }
}