using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.WbrBuilders;

internal sealed class WbrBuilder : IWbrBuilder
{
    private readonly WbrAttributes _attributes = new();

    public IWbrBuilder Attributes(Action<WbrAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Wbr Build()
    {
        throw new NotImplementedException();
    }
}
