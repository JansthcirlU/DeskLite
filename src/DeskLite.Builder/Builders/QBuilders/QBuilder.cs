using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.QBuilders;

internal sealed class QBuilder : IQBuilder
{
    private readonly QAttributes _attributes = new();

    public IQBuilder Attributes(Action<QAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Q Build()
    {
        throw new NotImplementedException();
    }
}
