namespace DeskLite.Builder.Elements.Base;

public interface IHtmlElementBase<TSelf> where TSelf : IHtmlElementBase<TSelf>
{
    string Name { get; }
}
