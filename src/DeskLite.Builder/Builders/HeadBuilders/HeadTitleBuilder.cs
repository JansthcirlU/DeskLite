using DeskLite.Builder.Builders.TitleBuilders;
using DeskLite.Builder.Builders.Primitives;
using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HeadBuilders;

internal sealed class HeadTitleBuilder : IHeadTitleBuilder, ITitleBuilder
{
    public ITitleBuilder Attributes(Action<TitleAttributes> attributes)
    {
        throw new NotImplementedException();
    }

    public IHeadBuilder Done()
    {
        throw new NotImplementedException();
    }

    public IElementBuilder<ITitleBuilder, TitleAttributes, Elements.Title> AsBuilder()
        => this;

    public Elements.Title Build()
    {
        throw new NotImplementedException();
    }
}
