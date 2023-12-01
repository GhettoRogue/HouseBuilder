using HouseBuilder.Model.Foundation;

namespace HouseBuilder.Factory.FoundationFactory;

public class WoodFoundationFactory : AFoundationFactory
{
    public WoodFoundationFactory(double width, double length) : base(width, length)
    {
    }
    
    public override AFoundation Create()
    {
        return new WoodFoundation(Width, Length);
    }
}