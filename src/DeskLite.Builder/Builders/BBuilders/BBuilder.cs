using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BBuilders;

internal sealed class BBuilder : IBBuilder
{
    private readonly BAttributes _attributes = new();

    public IBBuilder Attributes(Action<BAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.B Build()
    {
        throw new NotImplementedException();
    }
}
