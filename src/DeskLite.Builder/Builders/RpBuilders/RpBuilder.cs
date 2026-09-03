using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.RpBuilders;

internal sealed class RpBuilder : IRpBuilder
{
    private readonly RpAttributes _attributes = new();

    public IRpBuilder Attributes(Action<RpAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Rp Build()
    {
        throw new NotImplementedException();
    }
}
