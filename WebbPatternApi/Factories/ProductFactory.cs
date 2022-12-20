using CodePatternApi.Interfaces.Factories;
using CodePatternApi.Models;
using WebbPatternApi.Entities;

namespace CodePatternApi.Factories
{
    // Single responsivility, dess mål är att instansiera produkter.

    public class ProductFactory : IProductFactory
    {

        
        public ShoeProductModel ShoeProductModel() { return new ShoeProductModel(); }
        public ShoeProductModel ShoeProductModel(ShoeProductEntity entity)
        {
            return new ShoeProductModel()
            {
                ArtNumber = entity.ArtNumber,
                Brand = entity.Brand,
                Category = entity.Category,
                Color = entity.Color,
                ImgUrl = entity.ImgUrl,
                LongDescription = entity.LongDescription,
                Name = entity.Name,
                Price = entity.Price,
                Rating = entity.Rating,
                ShoeCategory = entity.ShoeCategory,
                ShortDescription = entity.ShortDescription,
                Size = entity.Size
            };
        }


        public TshirtProductModel TshirtProductModel() { return new TshirtProductModel(); }
        public TshirtProductModel TshirtProductModel(TshirtProductEntity entity)
        {
            return new TshirtProductModel()
            {
                ArtNumber = entity.ArtNumber,
                Brand = entity.Brand,
                Category = entity.Category,
                Color = entity.Color,
                ImgUrl = entity.ImgUrl,
                LongDescription = entity.LongDescription,
                Name = entity.Name,
                Price = entity.Price,
                Rating = entity.Rating,
                ShortDescription = entity.ShortDescription,
                Size = entity.Size,
                ArmLenght = entity.ArmLenght,
                NeckType = entity.NeckType,
                ShirtType = entity.ShirtType
            };


        }

        public WatchProductModel WatchProductModel() { return new WatchProductModel(); }
        public WatchProductModel WatchProductModel(WatchProductEntity entity)
        {
            return new WatchProductModel()
            {
                Analogue = entity.Analogue,
                ArtNumber = entity.ArtNumber,
                Brand = entity.Brand,
                Category = entity.Category,
                BandColor = entity.BandColor,
                DialColor = entity.DialColor,
                ImgUrl = entity.ImgUrl,
                LongDescription = entity.LongDescription,
                Name = entity.Name,
                Price = entity.Price,
                Rating = entity.Rating,
                ShortDescription = entity.ShortDescription,
                WaterResistant = entity.WaterResistant
            };

        }


    }
}
