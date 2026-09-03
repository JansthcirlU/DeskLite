using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BdiBuilders;

internal sealed class BdiBuilder : IBdiBuilder
{
    private readonly BdiAttributes _attributes = new();

    public IBdiBuilder Attributes(Action<BdiAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Bdi Build()
    {
        throw new NotImplementedException();
    }
}
