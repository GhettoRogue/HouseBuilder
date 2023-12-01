using HouseBuilder.Model.Roof;

namespace HouseBuilder.Factory.RoofFactory;

public class ThatchRoofFactory : ARoofFactory
{
    public ThatchRoofFactory(double width, double length, double height) : base(width, length, height)
    {
    }

    public override ARoof Create()
    {
        return new ThatchRoof(Width, Length, Height);
    }
}