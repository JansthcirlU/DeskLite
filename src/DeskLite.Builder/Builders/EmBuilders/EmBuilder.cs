using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.EmBuilders;

internal sealed class EmBuilder : IEmBuilder
{
    private readonly EmAttributes _attributes = new();

    public IEmBuilder Attributes(Action<EmAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Em Build()
    {
        throw new NotImplementedException();
    }
}
