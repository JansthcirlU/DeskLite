using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.PBuilders;

internal sealed class PBuilder : IPBuilder
{
    private readonly PAttributes _attributes = new();

    public IPBuilder Attributes(Action<PAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.P Build()
    {
        throw new NotImplementedException();
    }
}
