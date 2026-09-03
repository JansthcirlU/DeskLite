using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.CiteBuilders;

internal sealed class CiteBuilder : ICiteBuilder
{
    private readonly CiteAttributes _attributes = new();

    public ICiteBuilder Attributes(Action<CiteAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Cite Build()
    {
        throw new NotImplementedException();
    }
}
