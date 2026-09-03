using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.OlBuilders;

internal sealed class OlBuilder : IOlBuilder
{
    private readonly OlAttributes _attributes = new();

    public IOlBuilder Attributes(Action<OlAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Ol Build()
    {
        throw new NotImplementedException();
    }
}
