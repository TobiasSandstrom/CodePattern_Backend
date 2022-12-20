namespace CodePatternApi.Interfaces.Entities;

public interface ITshirtProductEntity : IBaseProductEntity
{
    string Size { get; set; }
    string Color { get; set; }
    string ShirtType { get; set; }
    string NeckType { get; set; }
    string ArmLenght { get; set; }
}
