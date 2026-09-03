using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TrBuilders;

internal sealed class TrBuilder : ITrBuilder
{
    private readonly TrAttributes _attributes = new();

    public ITrBuilder Attributes(Action<TrAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Tr Build()
    {
        throw new NotImplementedException();
    }
}
