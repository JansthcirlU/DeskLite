using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.AbbrBuilders;

internal sealed class AbbrBuilder : IAbbrBuilder
{
    private readonly AbbrAttributes _attributes = new();

    public IAbbrBuilder Attributes(Action<AbbrAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Abbr Build()
    {
        throw new NotImplementedException();
    }
}
