using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DtBuilders;

internal sealed class DtBuilder : IDtBuilder
{
    private readonly DtAttributes _attributes = new();

    public IDtBuilder Attributes(Action<DtAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Dt Build()
    {
        throw new NotImplementedException();
    }
}
