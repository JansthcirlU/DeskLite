using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DelBuilders;

internal sealed class DelBuilder : IDelBuilder
{
    private readonly DelAttributes _attributes = new();

    public IDelBuilder Attributes(Action<DelAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Del Build()
    {
        throw new NotImplementedException();
    }
}
