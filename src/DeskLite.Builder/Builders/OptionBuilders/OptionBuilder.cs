using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.OptionBuilders;

internal sealed class OptionBuilder : IOptionBuilder
{
    private readonly OptionAttributes _attributes = new();

    public IOptionBuilder Attributes(Action<OptionAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Option Build()
    {
        throw new NotImplementedException();
    }
}
