using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HtmlBuilders;

internal sealed class HtmlBuilder : IHtmlBuilder
{
    private readonly HtmlAttributes _attributes = new();

    public IHtmlBuilder Attributes(Action<HtmlAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public IHtmlHeadBuilder Head()
    {
        throw new NotImplementedException();
    }

    public IHtmlBodyBuilder Body()
    {
        throw new NotImplementedException();
    }

    public Elements.Html Build()
    {
        throw new NotImplementedException();
    }
}
