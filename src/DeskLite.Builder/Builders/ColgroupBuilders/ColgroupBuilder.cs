using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ColgroupBuilders;

internal sealed class ColgroupBuilder : IColgroupBuilder
{
    private readonly ColgroupAttributes _attributes = new();

    public IColgroupBuilder Attributes(Action<ColgroupAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Colgroup Build()
    {
        throw new NotImplementedException();
    }
}
