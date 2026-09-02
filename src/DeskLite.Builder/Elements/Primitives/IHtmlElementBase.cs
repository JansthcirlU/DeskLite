namespace DeskLite.Builder.Elements.Primitives;

public interface IHtmlElementBase<TSelf> where TSelf : IHtmlElementBase<TSelf>
{
    string Name { get; }
}
