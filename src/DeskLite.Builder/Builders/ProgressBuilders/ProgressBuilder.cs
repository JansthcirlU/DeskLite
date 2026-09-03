using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ProgressBuilders;

internal sealed class ProgressBuilder : IProgressBuilder
{
    private readonly ProgressAttributes _attributes = new();

    public IProgressBuilder Attributes(Action<ProgressAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Progress Build()
    {
        throw new NotImplementedException();
    }
}
