using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.H4Builders;

internal sealed class H4Builder : IH4Builder
{
    private readonly H4Attributes _attributes = new();

    public IH4Builder Attributes(Action<H4Attributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.H4 Build()
    {
        throw new NotImplementedException();
    }
}
