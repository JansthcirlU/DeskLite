using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Elements;

public record Option() : HtmlElement<Option, OptionAttributes>("option");