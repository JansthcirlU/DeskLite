using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.OutputBuilders;

internal sealed class OutputBuilder : IOutputBuilder
{
    private readonly OutputAttributes _attributes = new();

    public IOutputBuilder Attributes(Action<OutputAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Output Build()
    {
        throw new NotImplementedException();
    }
}
