namespace DeskLite.Builder.Elements.Attributes.Primitives;

public abstract record ElementAttributes<TElement>
{
    public string? Id { get; set; }
    public string? Class { get; set; }
    public string? Lang { get; set; }
}