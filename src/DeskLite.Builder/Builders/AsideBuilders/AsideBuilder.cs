using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.AsideBuilders;

internal sealed class AsideBuilder : IAsideBuilder
{
    private readonly AsideAttributes _attributes = new();

    public IAsideBuilder Attributes(Action<AsideAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Aside Build()
    {
        throw new NotImplementedException();
    }
}
