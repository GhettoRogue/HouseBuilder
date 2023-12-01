namespace HouseBuilder.Model.Window;

public abstract class AWindow
{
    public string Material { get; init; }
    public double Width { get; init; }
    public double Length { get; init; }

    protected AWindow(string material, double width, double length)
    {
        Material = material;
        Width = width;
        Length = length;
    }
}