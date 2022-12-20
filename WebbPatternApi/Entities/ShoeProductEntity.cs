using CodePatternApi.Interfaces.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebbPatternApi.Entities;


// LSP, ärver från en basklass och utökar den genom ISP

// Kom på i efterhand att jag kunnat gjort mina entiteter mer normaliserade, 
// som att ha en categori entitet som utökar produkten.


public class ShoeProductEntity : BaseProductEntity, IShoeProductEntity
{

    [Required]
    public string Size { get; set; } = null!;
    
    [Required]
    public string Color  { get; set; } = null!;
    
    [Required]
    public string ShoeCategory { get; set; } = null!;
 
}
