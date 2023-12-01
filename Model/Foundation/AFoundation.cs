namespace HouseBuilder.Model.Foundation;

public abstract class AFoundation
{
    public string Material { get; init; }
    public double Width { get; init; }
    public double Length { get; init; }

    protected AFoundation(string material, double width, double length)
    {
        Material = material;
        Width = width;
        Length = length;
    }
}