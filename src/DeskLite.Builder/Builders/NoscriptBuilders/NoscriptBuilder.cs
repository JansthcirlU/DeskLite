using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.NoscriptBuilders;

internal sealed class NoscriptBuilder : INoscriptBuilder
{
    private readonly NoscriptAttributes _attributes = new();

    public INoscriptBuilder Attributes(Action<NoscriptAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Noscript Build()
    {
        throw new NotImplementedException();
    }
}
