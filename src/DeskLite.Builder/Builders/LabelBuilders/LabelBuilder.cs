using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.LabelBuilders;

internal sealed class LabelBuilder : ILabelBuilder
{
    private readonly LabelAttributes _attributes = new();

    public ILabelBuilder Attributes(Action<LabelAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Label Build()
    {
        throw new NotImplementedException();
    }
}
