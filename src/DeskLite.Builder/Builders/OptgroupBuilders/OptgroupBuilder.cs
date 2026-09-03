using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.OptgroupBuilders;

internal sealed class OptgroupBuilder : IOptgroupBuilder
{
    private readonly OptgroupAttributes _attributes = new();

    public IOptgroupBuilder Attributes(Action<OptgroupAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Optgroup Build()
    {
        throw new NotImplementedException();
    }
}
