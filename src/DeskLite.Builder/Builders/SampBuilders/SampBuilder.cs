using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SampBuilders;

internal sealed class SampBuilder : ISampBuilder
{
    private readonly SampAttributes _attributes = new();

    public ISampBuilder Attributes(Action<SampAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Samp Build()
    {
        throw new NotImplementedException();
    }
}
