using HouseBuilder.Model.Foundation;

namespace HouseBuilder.Factory.FoundationFactory;

public abstract class AFoundationFactory : IFactory<AFoundation>
{
    public double Width { get; init; }
    public double Length { get; init; }

    protected AFoundationFactory(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public abstract AFoundation Create();
}