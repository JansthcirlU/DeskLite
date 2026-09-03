using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.FooterBuilders;

internal sealed class FooterBuilder : IFooterBuilder
{
    private readonly FooterAttributes _attributes = new();

    public IFooterBuilder Attributes(Action<FooterAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Footer Build()
    {
        throw new NotImplementedException();
    }
}
