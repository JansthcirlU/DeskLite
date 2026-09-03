using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.MeterBuilders;

internal sealed class MeterBuilder : IMeterBuilder
{
    private readonly MeterAttributes _attributes = new();

    public IMeterBuilder Attributes(Action<MeterAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Meter Build()
    {
        throw new NotImplementedException();
    }
}
