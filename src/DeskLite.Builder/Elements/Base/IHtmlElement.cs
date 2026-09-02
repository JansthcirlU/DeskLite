namespace DeskLite.Builder.Elements.Base;

public interface IHtmlElement<TSelf> where TSelf : IHtmlElement<TSelf>
{
    string Name { get; }
}
