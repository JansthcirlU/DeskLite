using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Elements;

public record Html(Head Head, Body Body) : HtmlElement<Html>("html");
public record Head() : HtmlElement<Head>("head");
public record Body() : HtmlElement<Body>("body");