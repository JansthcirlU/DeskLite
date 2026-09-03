using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TitleBuilders;

internal sealed class TitleBuilder : ITitleBuilder
{
    private readonly TitleAttributes _attributes = new();

    public ITitleBuilder Attributes(Action<TitleAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Title Build()
    {
        throw new NotImplementedException();
    }
}
