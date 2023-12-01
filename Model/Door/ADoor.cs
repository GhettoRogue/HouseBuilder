namespace HouseBuilder.Model.Door;

public abstract class ADoor
{
    public string Material { get; init; }
    public double Width { get; init; }
    public double Length { get; init; }

    protected ADoor(string material, double width, double length)
    {
        Material = material;
        Width = width;
        Length = length;
    }
}