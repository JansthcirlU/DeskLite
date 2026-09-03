using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.IBuilders;

internal sealed class IBuilder : IIBuilder
{
    private readonly IAttributes _attributes = new();

    public IIBuilder Attributes(Action<IAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.I Build()
    {
        throw new NotImplementedException();
    }
}
