using Microsoft.AspNetCore.Mvc;
using StoreCatalogService.Dto;

namespace StoreCatalogService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(StoreDto), 200)]
    public IActionResult Get()
    {
        return Ok();
    }
}