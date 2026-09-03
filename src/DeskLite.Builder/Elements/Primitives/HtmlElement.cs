using DeskLite.Builder.Elements.Attributes.Primitives;

namespace DeskLite.Builder.Elements.Primitives;

public abstract record HtmlElement<TSelf, TAttributes> :
    IHtmlElementBase<TSelf>
    where TSelf : HtmlElement<TSelf, TAttributes>
    where TAttributes : ElementAttributes<TSelf>, new()
{
    public TAttributes Attributes { get; }
    public string Name { get; }

    public HtmlElement(string name)
    {
        Attributes = new();
        Name = name;
    }
}