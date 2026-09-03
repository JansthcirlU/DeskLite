using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ThBuilders;

internal sealed class ThBuilder : IThBuilder
{
    private readonly ThAttributes _attributes = new();

    public IThBuilder Attributes(Action<ThAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Th Build()
    {
        throw new NotImplementedException();
    }
}
