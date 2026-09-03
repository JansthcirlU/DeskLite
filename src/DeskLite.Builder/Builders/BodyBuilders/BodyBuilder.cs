using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.BodyBuilders;

internal sealed class BodyBuilder : IBodyBuilder
{
    private readonly BodyAttributes _attributes = new();

    public IBodyBuilder Attributes(Action<BodyAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Body Build()
    {
        throw new NotImplementedException();
    }
}
