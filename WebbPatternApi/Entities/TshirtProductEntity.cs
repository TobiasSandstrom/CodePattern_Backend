using System.ComponentModel.DataAnnotations;
using CodePatternApi.Interfaces.Entities;

namespace WebbPatternApi.Entities;


// LSP, ärver från en basklass och utökar den genom ISP

// Kom på i efterhand att jag kunnat gjort mina entiteter mer normaliserade, 
// som att ha en categori entitet som utökar produkten.


public class TshirtProductEntity : BaseProductEntity, ITshirtProductEntity
{

    [Required]
    public string Size { get; set; } = null!;
    
    [Required]
    public string Color  { get; set; } = null!;
    
    [Required]
    public string ShirtType  { get; set; } = null!;
    
    [Required]
    public string NeckType { get; set; } = null!;
    
    [Required]
    public string ArmLenght { get; set; } = null!;

}
