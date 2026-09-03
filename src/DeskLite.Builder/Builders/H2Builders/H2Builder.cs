using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.H2Builders;

internal sealed class H2Builder : IH2Builder
{
    private readonly H2Attributes _attributes = new();

    public IH2Builder Attributes(Action<H2Attributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.H2 Build()
    {
        throw new NotImplementedException();
    }
}
