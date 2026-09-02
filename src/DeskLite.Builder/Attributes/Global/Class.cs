using DeskLite.Builder.Attributes.Base;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Attributes.Global;

public record Class<TElement> : IHtmlAttribute<Class<TElement>, TElement> where TElement : IHtmlElementBase<TElement>
{
    public string? Value { get; set; }
}
