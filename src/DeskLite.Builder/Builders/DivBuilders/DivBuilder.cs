using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DivBuilders;

internal sealed class DivBuilder : IDivBuilder
{
    private readonly DivAttributes _attributes = new();

    public IDivBuilder Attributes(Action<DivAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Div Build()
    {
        throw new NotImplementedException();
    }
}
