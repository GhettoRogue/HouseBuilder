using HouseBuilder.Model.Door;

namespace HouseBuilder.Factory.DoorFactory;

public class WoodDoor : ADoorFactory
{
    public WoodDoor(double width, double length) : base(width, length)
    {
    }

    public override ADoor Create()
    {
        return new Model.Door.WoodDoor(Width, Length);
    }
}