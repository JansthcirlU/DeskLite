using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SmallBuilders;

internal sealed class SmallBuilder : ISmallBuilder
{
    private readonly SmallAttributes _attributes = new();

    public ISmallBuilder Attributes(Action<SmallAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Small Build()
    {
        throw new NotImplementedException();
    }
}
