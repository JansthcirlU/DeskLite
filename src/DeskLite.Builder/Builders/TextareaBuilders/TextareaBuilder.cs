using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TextareaBuilders;

internal sealed class TextareaBuilder : ITextareaBuilder
{
    private readonly TextareaAttributes _attributes = new();

    public ITextareaBuilder Attributes(Action<TextareaAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Textarea Build()
    {
        throw new NotImplementedException();
    }
}
