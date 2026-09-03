using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SummaryBuilders;

internal sealed class SummaryBuilder : ISummaryBuilder
{
    private readonly SummaryAttributes _attributes = new();

    public ISummaryBuilder Attributes(Action<SummaryAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Summary Build()
    {
        throw new NotImplementedException();
    }
}
