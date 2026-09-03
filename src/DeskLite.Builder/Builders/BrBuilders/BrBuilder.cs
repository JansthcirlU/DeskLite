using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BrBuilders;

internal sealed class BrBuilder : IBrBuilder
{
    private readonly BrAttributes _attributes = new();

    public IBrBuilder Attributes(Action<BrAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Br Build()
    {
        throw new NotImplementedException();
    }
}
