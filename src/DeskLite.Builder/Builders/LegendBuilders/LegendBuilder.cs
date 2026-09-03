using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.LegendBuilders;

internal sealed class LegendBuilder : ILegendBuilder
{
    private readonly LegendAttributes _attributes = new();

    public ILegendBuilder Attributes(Action<LegendAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Legend Build()
    {
        throw new NotImplementedException();
    }
}
