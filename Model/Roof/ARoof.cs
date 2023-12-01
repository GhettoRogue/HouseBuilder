namespace HouseBuilder.Model.Roof;

public abstract class ARoof
{
    public string Material { get; init; }
    public double Width { get; init; }
    public double Length { get; init; }
    public double Height { get; init; }

    protected ARoof(string material, double width, double length, double height)
    {
        Material = material;
        Width = width;
        Length = length;
        Height = height;
    }
}