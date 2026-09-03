using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.UBuilders;

internal sealed class UBuilder : IUBuilder
{
    private readonly UAttributes _attributes = new();

    public IUBuilder Attributes(Action<UAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.U Build()
    {
        throw new NotImplementedException();
    }
}
