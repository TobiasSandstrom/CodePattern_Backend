namespace CodePatternApi.Interfaces.Factories;

// Kanske inte hade behövts ett interface för detta men var endå värt att göra ett då
// denna var lite knepigare att få till än de andra för tex entiteter

public interface IGenericFactory
{
    T CreateInstance<T>() where T : class, new();
}
