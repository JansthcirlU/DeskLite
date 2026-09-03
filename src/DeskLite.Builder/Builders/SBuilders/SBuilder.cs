using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SBuilders;

internal sealed class SBuilder : ISBuilder
{
    private readonly SAttributes _attributes = new();

    public ISBuilder Attributes(Action<SAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.S Build()
    {
        throw new NotImplementedException();
    }
}
