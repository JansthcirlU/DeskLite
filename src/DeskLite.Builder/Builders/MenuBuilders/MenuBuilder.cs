using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.MenuBuilders;

internal sealed class MenuBuilder : IMenuBuilder
{
    private readonly MenuAttributes _attributes = new();

    public IMenuBuilder Attributes(Action<MenuAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Menu Build()
    {
        throw new NotImplementedException();
    }
}
