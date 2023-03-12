using Microsoft.AspNetCore.Mvc;
using StoreCatalogService.Dto;

namespace StoreCatalogService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ProductResponseDto), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        return Ok();
    }
}