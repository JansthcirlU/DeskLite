using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HeadBuilders;

internal sealed class HeadBuilder : IHeadBuilder
{
    private readonly HeadAttributes _attributes = new();

    public IHeadBuilder Attributes(Action<HeadAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public IHeadTitleBuilder Title()
    {
        throw new NotImplementedException();
    }

    public Elements.Head Build()
    {
        throw new NotImplementedException();
    }
}
