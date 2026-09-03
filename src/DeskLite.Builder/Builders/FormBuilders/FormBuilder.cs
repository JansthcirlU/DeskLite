using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.FormBuilders;

internal sealed class FormBuilder : IFormBuilder
{
    private readonly FormAttributes _attributes = new();

    public IFormBuilder Attributes(Action<FormAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Form Build()
    {
        throw new NotImplementedException();
    }
}
