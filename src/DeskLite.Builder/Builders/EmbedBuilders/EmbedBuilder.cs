using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.EmbedBuilders;

internal sealed class EmbedBuilder : IEmbedBuilder
{
    private readonly EmbedAttributes _attributes = new();

    public IEmbedBuilder Attributes(Action<EmbedAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Embed Build()
    {
        throw new NotImplementedException();
    }
}
