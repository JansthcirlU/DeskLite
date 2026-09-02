using DeskLite.Builder.Attributes.Base;
using DeskLite.Builder.Elements;

namespace DeskLite.Builder.Attributes;

public record Xmlns : IHtmlAttribute<Xmlns, Html>
{
    public string? Value { get; set; }
}
