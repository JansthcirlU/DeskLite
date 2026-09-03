using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SelectBuilders;

internal sealed class SelectBuilder : ISelectBuilder
{
    private readonly SelectAttributes _attributes = new();

    public ISelectBuilder Attributes(Action<SelectAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Select Build()
    {
        throw new NotImplementedException();
    }
}
