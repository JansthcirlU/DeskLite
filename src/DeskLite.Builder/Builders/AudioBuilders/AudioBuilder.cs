using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.AudioBuilders;

internal sealed class AudioBuilder : IAudioBuilder
{
    private readonly AudioAttributes _attributes = new();

    public IAudioBuilder Attributes(Action<AudioAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Audio Build()
    {
        throw new NotImplementedException();
    }
}
