using CodePatternApi.Interfaces.Models;

namespace CodePatternApi.Models;


// LSP, denna klass kan andra entiteter ärva av
//
// OPC, genom att ha en basklass kan man utöka istället för att ändra i basklassen (Shoe, Tshirt, Watch)
// Även smidigt att göra detta då alla entiteter och modellerna kan läggas i en och samma lista.


public abstract class BaseProductModel : IBaseProductModel
{
    public string ArtNumber  { get; set; } = null!;
    public string ImgUrl  { get; set; } = null!;
    public string Name  { get; set; } = null!;
    public string ShortDescription  { get; set; } = null!;
    public string LongDescription  { get; set; } = null!;
    public string Brand  { get; set; } = null!;
    public string Category  { get; set; } = null!;
    public int Rating  { get; set; }
    public decimal Price  { get; set; }
}
