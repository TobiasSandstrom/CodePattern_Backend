using CodePatternApi.Interfaces.Entities;
using CodePatternApi.Interfaces.Models;

namespace CodePatternApi.Models;

// LSP, ärver från en basklass och utökar den genom ISP
public class ShoeProductModel : BaseProductModel, IShoeProductEntity
{
    public string Size { get; set; } = null!;
    public string Color  { get; set; } = null!;
    public string ShoeCategory  { get; set; } = null!;
}
