using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.FieldsetBuilders;

internal sealed class FieldsetBuilder : IFieldsetBuilder
{
    private readonly FieldsetAttributes _attributes = new();

    public IFieldsetBuilder Attributes(Action<FieldsetAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Fieldset Build()
    {
        throw new NotImplementedException();
    }
}
