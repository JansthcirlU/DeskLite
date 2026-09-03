using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SpanBuilders;

internal sealed class SpanBuilder : ISpanBuilder
{
    private readonly SpanAttributes _attributes = new();

    public ISpanBuilder Attributes(Action<SpanAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Span Build()
    {
        throw new NotImplementedException();
    }
}
