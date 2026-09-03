using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SearchBuilders;

internal sealed class SearchBuilder : ISearchBuilder
{
    private readonly SearchAttributes _attributes = new();

    public ISearchBuilder Attributes(Action<SearchAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Search Build()
    {
        throw new NotImplementedException();
    }
}
