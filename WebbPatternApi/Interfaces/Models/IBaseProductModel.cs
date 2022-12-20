using CodePatternApi.Interfaces.Entities;

namespace CodePatternApi.Interfaces.Models;

// Hade nog kunnat skippa denna och låtit BaseProductModel ärva av IBaseProductEntity istället,
// men valde att använda interface för good practice

public interface IBaseProductModel : IBaseProductEntity
{

}
