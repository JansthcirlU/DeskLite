using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TimeBuilders;

internal sealed class TimeBuilder : ITimeBuilder
{
    private readonly TimeAttributes _attributes = new();

    public ITimeBuilder Attributes(Action<TimeAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Time Build()
    {
        throw new NotImplementedException();
    }
}
