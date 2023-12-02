using HouseBuilder.Model.Door;

namespace HouseBuilder.Factory.DoorFactory;

public class PlasticDoor : ADoorFactory
{
    public PlasticDoor(double width, double length) : base(width, length)
    {
    }

    public override ADoor Create()
    {
        return new Model.Door.PlasticDoor(Width, Length);
    }
}