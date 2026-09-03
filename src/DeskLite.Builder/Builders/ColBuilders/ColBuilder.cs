using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ColBuilders;

internal sealed class ColBuilder : IColBuilder
{
    private readonly ColAttributes _attributes = new();

    public IColBuilder Attributes(Action<ColAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Col Build()
    {
        throw new NotImplementedException();
    }
}
