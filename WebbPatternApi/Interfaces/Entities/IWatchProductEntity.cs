namespace CodePatternApi.Interfaces.Entities;

public interface IWatchProductEntity : IBaseProductEntity
{
    string DialColor { get; set; }
    string BandColor { get; set; }
    bool Analogue { get; set; }
    bool WaterResistant { get; set; }
}
