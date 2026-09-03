using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TheadBuilders;

internal sealed class TheadBuilder : ITheadBuilder
{
    private readonly TheadAttributes _attributes = new();

    public ITheadBuilder Attributes(Action<TheadAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Thead Build()
    {
        throw new NotImplementedException();
    }
}
