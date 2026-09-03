using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.StrongBuilders;

internal sealed class StrongBuilder : IStrongBuilder
{
    private readonly StrongAttributes _attributes = new();

    public IStrongBuilder Attributes(Action<StrongAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Strong Build()
    {
        throw new NotImplementedException();
    }
}
