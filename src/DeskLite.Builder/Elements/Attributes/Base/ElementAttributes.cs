using DeskLite.Builder.Attributes.Global;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Elements.Attributes.Base;

public abstract record ElementAttributes<TElement> where TElement : IHtmlElementBase<TElement>
{
    public Id<TElement> Id { get; } = new();
    public Class<TElement> Class { get; } = new();
}