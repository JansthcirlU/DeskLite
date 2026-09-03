using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.DialogBuilders;

internal sealed class DialogBuilder : IDialogBuilder
{
    private readonly DialogAttributes _attributes = new();

    public IDialogBuilder Attributes(Action<DialogAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Dialog Build()
    {
        throw new NotImplementedException();
    }
}
