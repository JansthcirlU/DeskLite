using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DfnBuilders;

internal sealed class DfnBuilder : IDfnBuilder
{
    private readonly DfnAttributes _attributes = new();

    public IDfnBuilder Attributes(Action<DfnAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Dfn Build()
    {
        throw new NotImplementedException();
    }
}
