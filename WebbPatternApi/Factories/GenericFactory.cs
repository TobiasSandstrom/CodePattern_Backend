using CodePatternApi.Interfaces.Factories;

namespace CodePatternApi.Factories;

// Valde att göra två styclen factories, en generisk som används för att instansiera det mesta
// samt en "ProductFactory" vilken man kan både instansiera en tom samt skicka med en entitet som
// dennes värden mappas ut till den nya produktmodellen.

public class GenericFactory : IGenericFactory
{
    public T CreateInstance<T>() where T : class, new()
    {
        return new T();
    }
}
