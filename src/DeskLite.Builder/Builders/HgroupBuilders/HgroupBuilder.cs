using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HgroupBuilders;

internal sealed class HgroupBuilder : IHgroupBuilder
{
    private readonly HgroupAttributes _attributes = new();

    public IHgroupBuilder Attributes(Action<HgroupAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Hgroup Build()
    {
        throw new NotImplementedException();
    }
}
