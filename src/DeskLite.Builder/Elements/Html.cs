using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Elements;

public record Html(Head Head, Body Body) : HtmlElement<Html, HtmlAttributes>("html");
