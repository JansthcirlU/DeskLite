using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HeaderBuilders;

internal sealed class HeaderBuilder : IHeaderBuilder
{
    private readonly HeaderAttributes _attributes = new();

    public IHeaderBuilder Attributes(Action<HeaderAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Header Build()
    {
        throw new NotImplementedException();
    }
}
