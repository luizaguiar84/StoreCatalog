namespace StoreCatalogService.Dto;

public class ProductDto
{
    public string? StoreName { get; set; }
    public Guid UserId { get; set; }
    public IList<string>? Restrictions { get; set; }
}