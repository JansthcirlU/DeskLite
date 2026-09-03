using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BdoBuilders;

internal sealed class BdoBuilder : IBdoBuilder
{
    private readonly BdoAttributes _attributes = new();

    public IBdoBuilder Attributes(Action<BdoAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Bdo Build()
    {
        throw new NotImplementedException();
    }
}
