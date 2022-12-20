namespace CodePatternApi.Interfaces.Entities;


// Alla interfaces används som ett "kontrakt" / "manual" för vad som ska finnas på classen som ärver av denna.
// Använde detta för att "specificera" vad som ska finnas på en class samt att utöka ett annat interface/produkt

// Här skriver jag manualen för hur en basentitet ska se ut, sedan kan tex IWatchProductEntity ärva av denna och utöka med egna
// egenskaper som enbart ska finnas på en klocka.


public interface IBaseProductEntity
{
    string ArtNumber { get; set; }
    string ImgUrl { get; set; }
    string Name { get; set; }
    string ShortDescription { get; set; }
    string LongDescription { get; set; }
    string Brand { get; set; }
    string Category { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
}
