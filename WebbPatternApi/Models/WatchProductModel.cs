using CodePatternApi.Interfaces.Entities;

namespace CodePatternApi.Models;

// LSP, ärver från en basklass och utökar den genom ISP

public class WatchProductModel : BaseProductModel, IWatchProductEntity
{
    public string DialColor  { get; set; } = null!;
    public string BandColor  { get; set; } = null!;
    public bool Analogue  { get; set; }
    public bool WaterResistant  { get; set; }
}
