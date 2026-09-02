using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Elements;

public record Noscript() : HtmlElement<Noscript, NoscriptAttributes>("noscript");