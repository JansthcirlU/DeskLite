using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.KbdBuilders;

internal sealed class KbdBuilder : IKbdBuilder
{
    private readonly KbdAttributes _attributes = new();

    public IKbdBuilder Attributes(Action<KbdAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Kbd Build()
    {
        throw new NotImplementedException();
    }
}
