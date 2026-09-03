using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ObjectBuilders;

internal sealed class ObjectBuilder : IObjectBuilder
{
    private readonly ObjectAttributes _attributes = new();

    public IObjectBuilder Attributes(Action<ObjectAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Object Build()
    {
        throw new NotImplementedException();
    }
}
