using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.H1Builders;

internal sealed class H1Builder : IH1Builder
{
    private readonly H1Attributes _attributes = new();

    public IH1Builder Attributes(Action<H1Attributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.H1 Build()
    {
        throw new NotImplementedException();
    }
}
