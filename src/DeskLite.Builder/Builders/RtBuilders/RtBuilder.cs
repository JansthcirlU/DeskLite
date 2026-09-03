using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.RtBuilders;

internal sealed class RtBuilder : IRtBuilder
{
    private readonly RtAttributes _attributes = new();

    public IRtBuilder Attributes(Action<RtAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Rt Build()
    {
        throw new NotImplementedException();
    }
}
