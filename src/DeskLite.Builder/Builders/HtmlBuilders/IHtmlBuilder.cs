using DeskLite.Builder.Builders.Primitives;
using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HtmlBuilders;

public interface IHtmlBuilder : IElementBuilder<IHtmlBuilder, HtmlAttributes, Elements.Html>
{
    IHtmlHeadBuilder Head();
    IHtmlBodyBuilder Body();
}
