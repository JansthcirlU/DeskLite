using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.PreBuilders;

internal sealed class PreBuilder : IPreBuilder
{
    private readonly PreAttributes _attributes = new();

    public IPreBuilder Attributes(Action<PreAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Pre Build()
    {
        throw new NotImplementedException();
    }
}
