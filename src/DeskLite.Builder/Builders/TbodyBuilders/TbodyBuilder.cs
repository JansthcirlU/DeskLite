using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TbodyBuilders;

internal sealed class TbodyBuilder : ITbodyBuilder
{
    private readonly TbodyAttributes _attributes = new();

    public ITbodyBuilder Attributes(Action<TbodyAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Tbody Build()
    {
        throw new NotImplementedException();
    }
}
