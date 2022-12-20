using CodePatternApi.Data.Context;
using CodePatternApi.Interfaces.Factories;
using CodePatternApi.Interfaces.Handlers;
using CodePatternApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebbPatternApi.Entities;

namespace CodePatternApi.Handlers;

// Handler vars enda syfte är att hantera produkter.



public class ProductHandler : IProductHandler
{



    private readonly SqlContext _context;
    private readonly IProductFactory _productFactory;
    private readonly IGenericFactory _genericFactory;

    public ProductHandler(SqlContext context, IProductFactory productFactory, IGenericFactory genericFactory)
    {
        _context = context;
        _productFactory = productFactory;
        _genericFactory = genericFactory;
    }



    public async Task<IActionResult> GetAsync(string id, string category)
    {

        switch (category.ToLower())
        {
            case "shoes":
                var shoeRes = await _context.Shoes.FindAsync(id);
                if (shoeRes == null) return new NotFoundObjectResult(null);
                return new OkObjectResult(_productFactory.ShoeProductModel(shoeRes));

            case "tshirts":
                var tshirtRes = await _context.Tshirts.FindAsync(id);
                if (tshirtRes == null) return new NotFoundObjectResult(null);
                return new OkObjectResult(_productFactory.TshirtProductModel(tshirtRes));
            
            case "watches":
                var watchRes = await _context.Watches.FindAsync(id);
                if (watchRes == null) return new NotFoundObjectResult(null);  
                return new OkObjectResult(_productFactory.WatchProductModel(watchRes));

            default:
                return new NotFoundObjectResult(null);
        }
    }



    public async Task<IActionResult> GetShoeAsync(string id)
    {
        var shoeRes = await _context.Shoes.FindAsync(id);
        if (shoeRes == null) return new NotFoundObjectResult(null);
        return new OkObjectResult(_productFactory.ShoeProductModel(shoeRes));
    }

    public async Task<IActionResult> GetWatchAsync(string id)
    {
        var watchRes = await _context.Watches.FindAsync(id);
        if (watchRes == null) return new NotFoundObjectResult(null);
        return new OkObjectResult(_productFactory.WatchProductModel(watchRes));
    }

    public async Task<IActionResult> GetTshirtAsync(string id)
    {
        var tshirtRes = await _context.Tshirts.FindAsync(id);
        if (tshirtRes == null) return new NotFoundObjectResult(null);
        return new OkObjectResult(_productFactory.TshirtProductModel(tshirtRes));
    }










    public async Task<IActionResult> GetAllAsync()
    {
        List<BaseProductModel> products = _genericFactory.CreateInstance<List<BaseProductModel>>();
        
        foreach (var item in await _context.Shoes.ToListAsync())
        {
            ShoeProductModel shoe = _productFactory.ShoeProductModel(item);
            products.Add(shoe);
        };
        foreach (var item in await _context.Tshirts.ToListAsync())
        {
            TshirtProductModel tshirt = _productFactory.TshirtProductModel(item);
            products.Add(tshirt);
        };
        foreach (var item in await _context.Watches.ToListAsync())
        {
            WatchProductModel watch = _productFactory.WatchProductModel(item);
            products.Add(watch);
        };
        return new OkObjectResult(JsonConvert.SerializeObject(products));

    }

}
