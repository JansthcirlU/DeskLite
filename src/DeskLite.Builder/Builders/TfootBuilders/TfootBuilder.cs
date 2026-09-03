using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TfootBuilders;

internal sealed class TfootBuilder : ITfootBuilder
{
    private readonly TfootAttributes _attributes = new();

    public ITfootBuilder Attributes(Action<TfootAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Tfoot Build()
    {
        throw new NotImplementedException();
    }
}
