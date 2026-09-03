using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.VarBuilders;

internal sealed class VarBuilder : IVarBuilder
{
    private readonly VarAttributes _attributes = new();

    public IVarBuilder Attributes(Action<VarAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Var Build()
    {
        throw new NotImplementedException();
    }
}
