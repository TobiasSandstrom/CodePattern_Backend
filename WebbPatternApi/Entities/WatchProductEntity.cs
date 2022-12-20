using CodePatternApi.Interfaces.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebbPatternApi.Entities;


// LSP, ärver från en basklass och utökar den genom ISP

// Kom på i efterhand att jag kunnat gjort mina entiteter mer normaliserade, 
// som att ha en categori entitet som utökar produkten.


public class WatchProductEntity : BaseProductEntity, IWatchProductEntity
{

    [Required]
    public string DialColor { get; set; } = null!;

    [Required]
    public string BandColor { get; set; } = null!;

    [Required]
    public bool Analogue  { get; set; }

    [Required]
    public bool WaterResistant  { get; set; }
}
