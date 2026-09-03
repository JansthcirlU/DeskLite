using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BaseBuilders;

internal sealed class BaseBuilder : IBaseBuilder
{
    private readonly BaseAttributes _attributes = new();

    public IBaseBuilder Attributes(Action<BaseAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Base Build()
    {
        throw new NotImplementedException();
    }
}
