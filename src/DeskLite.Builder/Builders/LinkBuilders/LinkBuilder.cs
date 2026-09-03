using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.LinkBuilders;

internal sealed class LinkBuilder : ILinkBuilder
{
    private readonly LinkAttributes _attributes = new();

    public ILinkBuilder Attributes(Action<LinkAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Link Build()
    {
        throw new NotImplementedException();
    }
}
