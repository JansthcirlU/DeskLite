using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.VideoBuilders;

internal sealed class VideoBuilder : IVideoBuilder
{
    private readonly VideoAttributes _attributes = new();

    public IVideoBuilder Attributes(Action<VideoAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Video Build()
    {
        throw new NotImplementedException();
    }
}
