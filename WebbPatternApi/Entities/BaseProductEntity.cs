using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodePatternApi.Interfaces.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebbPatternApi.Entities;

// LSP, denna klass kan andra entiteter ärva av
//
// OPC, genom att ha en basklass kan man utöka istället för att ändra i basklassen (Shoe, Tshirt, Watch)
// Även smidigt att göra detta då alla entiteter och modellerna kan läggas i en och samma lista.


public class BaseProductEntity : IBaseProductEntity
{
    [Key]
    [Required]
    public string ArtNumber { get; set; } = null!;

    [Required]
    public string ImgUrl { get; set; } = null!;
    
    [Required]
    public string Name  { get; set; } = null!;

    [Required]
    public string ShortDescription  { get; set; } = null!;

    [Required] public string LongDescription { get; set; } = null!;
    
    [Required] public string Brand { get; set; } = null!;
    
    [Required] public string Category { get; set; } = null!;

    [Required]
    public int Rating  { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal Price  { get; set; }
}
