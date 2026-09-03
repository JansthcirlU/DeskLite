using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ArticleBuilders;

internal sealed class ArticleBuilder : IArticleBuilder
{
    private readonly ArticleAttributes _attributes = new();

    public IArticleBuilder Attributes(Action<ArticleAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Article Build()
    {
        throw new NotImplementedException();
    }
}
