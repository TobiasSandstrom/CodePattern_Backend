using CodePatternApi.Interfaces.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CodePatternApi.Controllers;



// Kontroller vars enda syfte är att hantera produkters http requests
// Dependency Inversion, genom att använda ProductHandler som instansieras program.cs tar man bor
// High-Level -> Low-Level beroenden.

[Route("api/")]
[ApiController]
public class ProductController : ControllerBase
{

    private readonly IProductHandler _productHandler;

    public ProductController(IProductHandler productHandler)
    {
        _productHandler = productHandler;
    }



    [HttpGet]
    [Route("products")]
    public async Task<IActionResult> GetAll()
    {
        return await _productHandler.GetAllAsync();
    }


    [HttpGet]
    [Route("product/Shoes")]

    public async Task<IActionResult> GetShoe([FromQuery] string id)
    {
        return await _productHandler.GetShoeAsync(id);
    }

    [HttpGet]
    [Route("product/Watches")]

    public async Task<IActionResult> GetWatch([FromQuery] string id)
    {
        return await _productHandler.GetWatchAsync(id);
    }

    [HttpGet]
    [Route("product/Tshirts")]

    public async Task<IActionResult> GetTshirt([FromQuery] string id)
    {
        return await _productHandler.GetTshirtAsync(id);
    }
}
