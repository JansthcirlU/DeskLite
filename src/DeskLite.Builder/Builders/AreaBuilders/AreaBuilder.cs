using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.AreaBuilders;

internal sealed class AreaBuilder : IAreaBuilder
{
    private readonly AreaAttributes _attributes = new();

    public IAreaBuilder Attributes(Action<AreaAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Area Build()
    {
        throw new NotImplementedException();
    }
}
