using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.CanvasBuilders;

internal sealed class CanvasBuilder : ICanvasBuilder
{
    private readonly CanvasAttributes _attributes = new();

    public ICanvasBuilder Attributes(Action<CanvasAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Canvas Build()
    {
        throw new NotImplementedException();
    }
}
