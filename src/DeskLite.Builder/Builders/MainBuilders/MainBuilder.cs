using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.MainBuilders;

internal sealed class MainBuilder : IMainBuilder
{
    private readonly MainAttributes _attributes = new();

    public IMainBuilder Attributes(Action<MainAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Main Build()
    {
        throw new NotImplementedException();
    }
}
