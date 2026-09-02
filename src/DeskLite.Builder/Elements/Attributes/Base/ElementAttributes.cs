using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Elements.Attributes.Base;

public abstract record ElementAttributes<TElement> where TElement : IHtmlElementBase<TElement>
{
    public string? Id { get; set; }
    public string? Class { get; set; }
}