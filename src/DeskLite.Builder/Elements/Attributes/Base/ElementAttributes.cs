namespace DeskLite.Builder.Elements.Attributes.Base;

public abstract record ElementAttributes<TElement>
{
    public string? Id { get; set; }
    public string? Class { get; set; }
}