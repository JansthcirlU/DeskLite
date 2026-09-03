using DeskLite.Builder.Builders.Primitives;
using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.HeadBuilders;

public interface IHeadBuilder : IElementBuilder<IHeadBuilder, HeadAttributes, Elements.Head>
{
    IHeadTitleBuilder Title();
}
