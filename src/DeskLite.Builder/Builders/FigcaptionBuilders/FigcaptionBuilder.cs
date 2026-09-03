using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.FigcaptionBuilders;

internal sealed class FigcaptionBuilder : IFigcaptionBuilder
{
    private readonly FigcaptionAttributes _attributes = new();

    public IFigcaptionBuilder Attributes(Action<FigcaptionAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Figcaption Build()
    {
        throw new NotImplementedException();
    }
}
