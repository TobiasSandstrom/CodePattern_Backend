using CodePatternApi.Interfaces.Entities;

namespace CodePatternApi.Models;

// LSP, ärver från en basklass och utökar den genom ISP

public class TshirtProductModel : BaseProductModel, ITshirtProductEntity
{
    public string Size  { get; set; } = null!;
    public string Color  { get; set; } = null!;
    public string ShirtType  { get; set; } = null!;
    public string NeckType  { get; set; } = null!;
    public string ArmLenght  { get; set; } = null!;
}
