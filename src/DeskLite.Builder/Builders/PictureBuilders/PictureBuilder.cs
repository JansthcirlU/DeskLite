using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.PictureBuilders;

internal sealed class PictureBuilder : IPictureBuilder
{
    private readonly PictureAttributes _attributes = new();

    public IPictureBuilder Attributes(Action<PictureAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Picture Build()
    {
        throw new NotImplementedException();
    }
}
