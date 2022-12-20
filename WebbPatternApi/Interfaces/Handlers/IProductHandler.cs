using Microsoft.AspNetCore.Mvc;


namespace CodePatternApi.Interfaces.Handlers;

// Interface som specar upp vad som ska finnas på en produktHandler


public interface IProductHandler
{
    Task<IActionResult> GetShoeAsync(string id);
    Task<IActionResult> GetWatchAsync(string id);
    Task<IActionResult> GetTshirtAsync(string id);
    Task<IActionResult> GetAsync(string id, string productId);
    Task<IActionResult> GetAllAsync();

}
