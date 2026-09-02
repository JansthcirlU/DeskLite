using DeskLite.Builder.Elements.Attributes;
using DeskLite.Builder.Elements.Primitives;

namespace DeskLite.Builder.Elements;

public record Label() : HtmlElement<Label, LabelAttributes>("label");