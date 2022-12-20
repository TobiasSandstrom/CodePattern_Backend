using CodePatternApi.Models;
using WebbPatternApi.Entities;

namespace CodePatternApi.Interfaces.Factories;

public interface IProductFactory
{
    ShoeProductModel ShoeProductModel();
    ShoeProductModel ShoeProductModel(ShoeProductEntity entity);
    TshirtProductModel TshirtProductModel();
    TshirtProductModel TshirtProductModel(TshirtProductEntity entity);
    WatchProductModel WatchProductModel();
    WatchProductModel WatchProductModel(WatchProductEntity entity);

}
