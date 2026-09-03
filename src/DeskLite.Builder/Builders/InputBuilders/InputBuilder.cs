using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.InputBuilders;

internal sealed class InputBuilder : IInputBuilder
{
    private readonly InputAttributes _attributes = new();

    public IInputBuilder Attributes(Action<InputAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Input Build()
    {
        throw new NotImplementedException();
    }
}
