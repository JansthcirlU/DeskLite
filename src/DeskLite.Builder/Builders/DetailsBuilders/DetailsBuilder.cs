using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DetailsBuilders;

internal sealed class DetailsBuilder : IDetailsBuilder
{
    private readonly DetailsAttributes _attributes = new();

    public IDetailsBuilder Attributes(Action<DetailsAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Details Build()
    {
        throw new NotImplementedException();
    }
}
