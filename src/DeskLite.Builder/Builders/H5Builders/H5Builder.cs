using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.H5Builders;

internal sealed class H5Builder : IH5Builder
{
    private readonly H5Attributes _attributes = new();

    public IH5Builder Attributes(Action<H5Attributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.H5 Build()
    {
        throw new NotImplementedException();
    }
}
