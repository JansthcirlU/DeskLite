using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DataBuilders;

internal sealed class DataBuilder : IDataBuilder
{
    private readonly DataAttributes _attributes = new();

    public IDataBuilder Attributes(Action<DataAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Data Build()
    {
        throw new NotImplementedException();
    }
}
