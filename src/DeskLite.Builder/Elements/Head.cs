using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Elements;

public record Head(Title Title) : HtmlElement<Head, HeadAttributes>("head");
