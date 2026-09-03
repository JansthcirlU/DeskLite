using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DdBuilders;

internal sealed class DdBuilder : IDdBuilder
{
    private readonly DdAttributes _attributes = new();

    public IDdBuilder Attributes(Action<DdAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Dd Build()
    {
        throw new NotImplementedException();
    }
}
