using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.H6Builders;

internal sealed class H6Builder : IH6Builder
{
    private readonly H6Attributes _attributes = new();

    public IH6Builder Attributes(Action<H6Attributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.H6 Build()
    {
        throw new NotImplementedException();
    }
}
