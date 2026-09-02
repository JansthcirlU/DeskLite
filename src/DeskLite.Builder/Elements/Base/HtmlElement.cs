using DeskLite.Builder.Attributes.Global;

namespace DeskLite.Builder.Elements.Base;

public abstract record HtmlElement<TSelf> :
    IHtmlElementBase<TSelf>,
    IHasGlobalAttributes<TSelf>
    where TSelf : HtmlElement<TSelf>
{
    public string Name { get; }
    public Id<TSelf> Id { get; }
    public Class<TSelf> Class { get; }

    public HtmlElement(string name, string? id = null, string? classes = null)
    {
        Name = name;
        Id = new(id);
        Class = new(classes);
    }
}