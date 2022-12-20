namespace CodePatternApi.Interfaces.Entities;

public interface IShoeProductEntity : IBaseProductEntity
{
    string Size { get; set; }
    string Color { get; set; }
    string ShoeCategory { get; set; }

}
