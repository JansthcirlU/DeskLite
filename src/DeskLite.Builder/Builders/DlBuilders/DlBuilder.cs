using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DlBuilders;

internal sealed class DlBuilder : IDlBuilder
{
    private readonly DlAttributes _attributes = new();

    public IDlBuilder Attributes(Action<DlAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Dl Build()
    {
        throw new NotImplementedException();
    }
}
