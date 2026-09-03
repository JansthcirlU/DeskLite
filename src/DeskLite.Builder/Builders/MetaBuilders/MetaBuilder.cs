using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.MetaBuilders;

internal sealed class MetaBuilder : IMetaBuilder
{
    private readonly MetaAttributes _attributes = new();

    public IMetaBuilder Attributes(Action<MetaAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Meta Build()
    {
        throw new NotImplementedException();
    }
}
