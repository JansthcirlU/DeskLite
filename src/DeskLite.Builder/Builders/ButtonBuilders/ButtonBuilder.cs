using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ButtonBuilders;

internal sealed class ButtonBuilder : IButtonBuilder
{
    private readonly ButtonAttributes _attributes = new();

    public IButtonBuilder Attributes(Action<ButtonAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Button Build()
    {
        throw new NotImplementedException();
    }
}
