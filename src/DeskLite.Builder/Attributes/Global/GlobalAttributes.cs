using DeskLite.Builder.Attributes.Base;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Attributes.Global;

public record Id<TElement>(string? Value) : IHtmlAttribute<Id<TElement>, TElement> where TElement : IHtmlElementBase<TElement>;
public record Class<TElement>(string? Value) : IHtmlAttribute<Class<TElement>, TElement> where TElement : IHtmlElementBase<TElement>;