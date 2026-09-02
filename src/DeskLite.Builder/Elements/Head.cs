using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Elements;

public record Head(Title Title) : HtmlElement<Head, HeadAttributes>("head");
