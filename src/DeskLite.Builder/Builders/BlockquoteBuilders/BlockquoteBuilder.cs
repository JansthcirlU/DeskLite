using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BlockquoteBuilders;

internal sealed class BlockquoteBuilder : IBlockquoteBuilder
{
    private readonly BlockquoteAttributes _attributes = new();

    public IBlockquoteBuilder Attributes(Action<BlockquoteAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Blockquote Build()
    {
        throw new NotImplementedException();
    }
}
