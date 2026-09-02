using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Elements;

public record Iframe() : HtmlElement<Iframe, IframeAttributes>("iframe");