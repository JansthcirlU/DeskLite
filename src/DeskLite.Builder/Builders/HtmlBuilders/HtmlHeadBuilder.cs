using DeskLite.Builder.Builders.HeadBuilders;
using DeskLite.Builder.Builders.Primitives;
using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HtmlBuilders;

internal sealed class HtmlHeadBuilder : IHtmlHeadBuilder, IHeadBuilder
{
    public IHeadBuilder Attributes(Action<HeadAttributes> attributes)
    {
        throw new NotImplementedException();
    }

    public IHeadTitleBuilder Title()
    {
        throw new NotImplementedException();
    }

    public IHtmlBuilder Done()
    {
        throw new NotImplementedException();
    }

    public IElementBuilder<IHeadBuilder, HeadAttributes, Elements.Head> AsBuilder()
        => this;

    public Elements.Head Build()
    {
        throw new NotImplementedException();
    }
}
