using DeskLite.Builder.Attributes.Base;
using DeskLite.Builder.Elements;

namespace DeskLite.Builder.Attributes;

public record Version : IHtmlAttribute<Version, Html>
{
    public string? Value { get; set; }
}
