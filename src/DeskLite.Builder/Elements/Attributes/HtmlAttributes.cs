using DeskLite.Builder.Elements.Attributes.Base;

namespace DeskLite.Builder.Elements.Attributes;

public sealed record HtmlAttributes : ElementAttributes<Html>
{
    public string? Version { get; set; }
    public string? Xmlns { get; set; }
}
