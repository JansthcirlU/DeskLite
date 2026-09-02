using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Base;

namespace DeskLite.Builder.Elements;

public record Title() : HtmlElement<Title, TitleAttributes>("title");