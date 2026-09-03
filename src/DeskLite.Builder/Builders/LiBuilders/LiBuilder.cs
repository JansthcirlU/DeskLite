using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.LiBuilders;

internal sealed class LiBuilder : ILiBuilder
{
    private readonly LiAttributes _attributes = new();

    public ILiBuilder Attributes(Action<LiAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Li Build()
    {
        throw new NotImplementedException();
    }
}
