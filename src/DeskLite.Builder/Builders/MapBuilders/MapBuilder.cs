using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.MapBuilders;

internal sealed class MapBuilder : IMapBuilder
{
    private readonly MapAttributes _attributes = new();

    public IMapBuilder Attributes(Action<MapAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Map Build()
    {
        throw new NotImplementedException();
    }
}
