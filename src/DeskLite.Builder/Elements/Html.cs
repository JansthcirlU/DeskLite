using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Elements;

public record Html(Head Head, Body Body) : HtmlElement<Html, HtmlAttributes>("html");
