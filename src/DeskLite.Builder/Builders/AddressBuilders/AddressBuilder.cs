using DeskLite.Builder.Elements.Attributes;

namespace DeskLite.Builder.Builders.AddressBuilders;

internal sealed class AddressBuilder : IAddressBuilder
{
    private readonly AddressAttributes _attributes = new();

    public IAddressBuilder Attributes(Action<AddressAttributes> attributes)
    {
        attributes(_attributes);
        return this;
    }

    public Elements.Address Build()
    {
        throw new NotImplementedException();
    }
}
