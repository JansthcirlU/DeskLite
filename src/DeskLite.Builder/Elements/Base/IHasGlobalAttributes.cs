using DeskLite.Builder.Attributes.Global;

namespace DeskLite.Builder.Elements.Base;

public interface IHasGlobalAttributes<TSelf>
    where TSelf : IHtmlElementBase<TSelf>
{
    Id<TSelf> Id { get; }
    Class<TSelf> Class { get; }
}
