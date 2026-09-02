using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Attributes.Base;

public interface IHtmlAttribute<TSelf, TElement>
    where TSelf : IHtmlAttribute<TSelf, TElement>
    where TElement : IHtmlElement<TElement>
{
    
}
