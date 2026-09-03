using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.FigureBuilders;

internal sealed class FigureBuilder : IFigureBuilder
{
    private readonly FigureAttributes _attributes = new();

    public IFigureBuilder Attributes(Action<FigureAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Figure Build()
    {
        throw new NotImplementedException();
    }
}
