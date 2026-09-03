using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ScriptBuilders;

internal sealed class ScriptBuilder : IScriptBuilder
{
    private readonly ScriptAttributes _attributes = new();

    public IScriptBuilder Attributes(Action<ScriptAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Script Build()
    {
        throw new NotImplementedException();
    }
}
