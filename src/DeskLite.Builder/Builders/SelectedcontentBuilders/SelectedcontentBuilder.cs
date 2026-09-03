using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SelectedcontentBuilders;

internal sealed class SelectedcontentBuilder : ISelectedcontentBuilder
{
    private readonly SelectedcontentAttributes _attributes = new();

    public ISelectedcontentBuilder Attributes(Action<SelectedcontentAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Selectedcontent Build()
    {
        throw new NotImplementedException();
    }
}
