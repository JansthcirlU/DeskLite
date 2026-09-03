using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DatalistBuilders;

internal sealed class DatalistBuilder : IDatalistBuilder
{
    private readonly DatalistAttributes _attributes = new();

    public IDatalistBuilder Attributes(Action<DatalistAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Datalist Build()
    {
        throw new NotImplementedException();
    }
}
