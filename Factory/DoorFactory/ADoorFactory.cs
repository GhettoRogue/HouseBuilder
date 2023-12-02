using HouseBuilder.Model.Door;

namespace HouseBuilder.Factory.DoorFactory;

public abstract class ADoorFactory : IFactory<ADoor>
{
    public double Width { get; init; }
    
    public double Length { get; init; }

    protected ADoorFactory(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public abstract ADoor Create();
}