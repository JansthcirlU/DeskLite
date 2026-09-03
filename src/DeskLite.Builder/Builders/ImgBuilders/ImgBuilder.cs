using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.ImgBuilders;

internal sealed class ImgBuilder : IImgBuilder
{
    private readonly ImgAttributes _attributes = new();

    public IImgBuilder Attributes(Action<ImgAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Img Build()
    {
        throw new NotImplementedException();
    }
}
