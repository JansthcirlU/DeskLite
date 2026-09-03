using DeskLite.Builder.Elements.Attributes.Primitives;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Builders.Primitives;

public interface IIntermediateBuilder<TParent, TParentAttributes, TParentResult, TSelf, TAttributes, TResult>
    where TParent : IElementBuilder<TParent, TParentAttributes, TParentResult>
    where TParentAttributes : ElementAttributes<TParentResult>, new()
    where TParentResult : HtmlElement<TParentResult, TParentAttributes>
    where TSelf : IElementBuilder<TSelf, TAttributes, TResult>
    where TAttributes : ElementAttributes<TResult>, new()
    where TResult : HtmlElement<TResult, TAttributes>
{
    TParent Done();
    IElementBuilder<TSelf, TAttributes, TResult> AsBuilder();
}
