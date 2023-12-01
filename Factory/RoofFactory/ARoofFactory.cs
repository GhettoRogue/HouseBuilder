using HouseBuilder.Model.Roof;

namespace HouseBuilder.Factory.RoofFactory;

public abstract class ARoofFactory : IFactory<ARoof>
{
    public double Width { get; init; }
    public double Length { get; init; }
    public double Height { get; init; }

    protected ARoofFactory(double width, double length, double height)
    {
        Width = width;
        Length = length;
        Height = height;
    }
    
    public abstract ARoof Create();
}