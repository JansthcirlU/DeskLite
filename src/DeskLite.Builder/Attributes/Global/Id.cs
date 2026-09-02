using DeskLite.Builder.Attributes.Base;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Attributes.Global;

public record Id<TElement> : IHtmlAttribute<Id<TElement>, TElement> where TElement : IHtmlElementBase<TElement>
{
    public string? Value { get; set; }
}
