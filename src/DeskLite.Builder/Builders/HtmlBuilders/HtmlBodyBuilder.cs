using DeskLite.Builder.Builders.BodyBuilders;
using DeskLite.Builder.Builders.Primitives;
using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HtmlBuilders;

internal sealed class HtmlBodyBuilder : IHtmlBodyBuilder, IBodyBuilder
{
    public IBodyBuilder Attributes(Action<BodyAttributes> attributes)
    {
        throw new NotImplementedException();
    }

    public IHtmlBuilder Done()
    {
        throw new NotImplementedException();
    }

    public IElementBuilder<IBodyBuilder, BodyAttributes, Elements.Body> AsBuilder()
        => this;

    public Elements.Body Build()
    {
        throw new NotImplementedException();
    }
}
