using DeskLite.Builder.Elements.Attributes.Primitives;

namespace DeskLite.Builder.Elements.Attributes;

public sealed record AAttributes : ElementAttributes<A>
{
    public string? Download { get; set; }
    public string? Href { get; set; }
    public string? Type { get; set; }
}
