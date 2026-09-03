using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TemplateBuilders;

internal sealed class TemplateBuilder : ITemplateBuilder
{
    private readonly TemplateAttributes _attributes = new();

    public ITemplateBuilder Attributes(Action<TemplateAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Template Build()
    {
        throw new NotImplementedException();
    }
}
