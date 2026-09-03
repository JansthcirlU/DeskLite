using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.H3Builders;

internal sealed class H3Builder : IH3Builder
{
    private readonly H3Attributes _attributes = new();

    public IH3Builder Attributes(Action<H3Attributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.H3 Build()
    {
        throw new NotImplementedException();
    }
}
