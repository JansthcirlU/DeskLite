using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.IframeBuilders;

internal sealed class IframeBuilder : IIframeBuilder
{
    private readonly IframeAttributes _attributes = new();

    public IIframeBuilder Attributes(Action<IframeAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Iframe Build()
    {
        throw new NotImplementedException();
    }
}
