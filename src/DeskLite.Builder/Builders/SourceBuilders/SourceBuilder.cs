using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SourceBuilders;

internal sealed class SourceBuilder : ISourceBuilder
{
    private readonly SourceAttributes _attributes = new();

    public ISourceBuilder Attributes(Action<SourceAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Source Build()
    {
        throw new NotImplementedException();
    }
}
