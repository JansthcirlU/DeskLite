using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.NavBuilders;

internal sealed class NavBuilder : INavBuilder
{
    private readonly NavAttributes _attributes = new();

    public INavBuilder Attributes(Action<NavAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Nav Build()
    {
        throw new NotImplementedException();
    }
}
