using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SupBuilders;

internal sealed class SupBuilder : ISupBuilder
{
    private readonly SupAttributes _attributes = new();

    public ISupBuilder Attributes(Action<SupAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Sup Build()
    {
        throw new NotImplementedException();
    }
}
