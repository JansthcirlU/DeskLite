using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.TrackBuilders;

internal sealed class TrackBuilder : ITrackBuilder
{
    private readonly TrackAttributes _attributes = new();

    public ITrackBuilder Attributes(Action<TrackAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Track Build()
    {
        throw new NotImplementedException();
    }
}
