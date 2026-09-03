using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.SlotBuilders;

internal sealed class SlotBuilder : ISlotBuilder
{
    private readonly SlotAttributes _attributes = new();

    public ISlotBuilder Attributes(Action<SlotAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Slot Build()
    {
        throw new NotImplementedException();
    }
}
