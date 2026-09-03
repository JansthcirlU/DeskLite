using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.CaptionBuilders;

internal sealed class CaptionBuilder : ICaptionBuilder
{
    private readonly CaptionAttributes _attributes = new();

    public ICaptionBuilder Attributes(Action<CaptionAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Caption Build()
    {
        throw new NotImplementedException();
    }
}
