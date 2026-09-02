using DeskLite.Builder.Attributes;
using DeskLite.Builder.Elements.Attributes.Base;
using Version = DeskLite.Builder.Attributes.Version;

namespace DeskLite.Builder.Elements.Attributes;

public sealed record HtmlAttributes : ElementAttributes<Html>
{
    public Version Version { get; } = new();
    public Xmlns Xmlns { get; } = new();
}
