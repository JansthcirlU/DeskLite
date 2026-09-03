using DeskLite.Builder.Elements.Attributes.Base;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Builders.Primitives;

public interface IElementBuilder<TSelf, TAttributes, TResult>
    where TSelf : IElementBuilder<TSelf, TAttributes, TResult>
    where TAttributes : ElementAttributes<TResult>, new()
    where TResult : HtmlElement<TResult, TAttributes>
{
    TResult Build();
}
