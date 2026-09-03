using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.StyleBuilders;

internal sealed class StyleBuilder : IStyleBuilder
{
    private readonly StyleAttributes _attributes = new();

    public IStyleBuilder Attributes(Action<StyleAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Style Build()
    {
        throw new NotImplementedException();
    }
}
