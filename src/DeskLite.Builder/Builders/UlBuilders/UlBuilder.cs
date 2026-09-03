using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.UlBuilders;

internal sealed class UlBuilder : IUlBuilder
{
    private readonly UlAttributes _attributes = new();

    public IUlBuilder Attributes(Action<UlAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Ul Build()
    {
        throw new NotImplementedException();
    }
}
