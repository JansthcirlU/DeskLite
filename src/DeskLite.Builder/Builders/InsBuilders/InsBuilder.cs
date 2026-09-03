using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.InsBuilders;

internal sealed class InsBuilder : IInsBuilder
{
    private readonly InsAttributes _attributes = new();

    public IInsBuilder Attributes(Action<InsAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Ins Build()
    {
        throw new NotImplementedException();
    }
}
