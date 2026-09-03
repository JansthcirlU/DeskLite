using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ABuilders;

internal sealed class ABuilder : IABuilder
{
    private readonly AAttributes _attributes = new();

    public IABuilder Attributes(Action<AAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.A Build()
    {
        throw new NotImplementedException();
    }
}
