using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SectionBuilders;

internal sealed class SectionBuilder : ISectionBuilder
{
    private readonly SectionAttributes _attributes = new();

    public ISectionBuilder Attributes(Action<SectionAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Section Build()
    {
        throw new NotImplementedException();
    }
}
