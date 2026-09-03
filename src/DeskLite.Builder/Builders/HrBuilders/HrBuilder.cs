using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HrBuilders;

internal sealed class HrBuilder : IHrBuilder
{
    private readonly HrAttributes _attributes = new();

    public IHrBuilder Attributes(Action<HrAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Hr Build()
    {
        throw new NotImplementedException();
    }
}
