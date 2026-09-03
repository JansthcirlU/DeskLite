using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TableBuilders;

internal sealed class TableBuilder : ITableBuilder
{
    private readonly TableAttributes _attributes = new();

    public ITableBuilder Attributes(Action<TableAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Table Build()
    {
        throw new NotImplementedException();
    }
}
