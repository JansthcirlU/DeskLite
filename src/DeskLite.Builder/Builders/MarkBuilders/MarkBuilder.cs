using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.MarkBuilders;

internal sealed class MarkBuilder : IMarkBuilder
{
    private readonly MarkAttributes _attributes = new();

    public IMarkBuilder Attributes(Action<MarkAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Mark Build()
    {
        throw new NotImplementedException();
    }
}
