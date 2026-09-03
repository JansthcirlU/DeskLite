using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TdBuilders;

internal sealed class TdBuilder : ITdBuilder
{
    private readonly TdAttributes _attributes = new();

    public ITdBuilder Attributes(Action<TdAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Td Build()
    {
        throw new NotImplementedException();
    }
}
