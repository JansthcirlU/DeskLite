using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SubBuilders;

internal sealed class SubBuilder : ISubBuilder
{
    private readonly SubAttributes _attributes = new();

    public ISubBuilder Attributes(Action<SubAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Sub Build()
    {
        throw new NotImplementedException();
    }
}
