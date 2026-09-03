using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.CodeBuilders;

internal sealed class CodeBuilder : ICodeBuilder
{
    private readonly CodeAttributes _attributes = new();

    public ICodeBuilder Attributes(Action<CodeAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Code Build()
    {
        throw new NotImplementedException();
    }
}
