using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.RubyBuilders;

internal sealed class RubyBuilder : IRubyBuilder
{
    private readonly RubyAttributes _attributes = new();

    public IRubyBuilder Attributes(Action<RubyAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Ruby Build()
    {
        throw new NotImplementedException();
    }
}
