using HouseBuilder.Model.Door;
using HouseBuilder.Model.Window;

namespace HouseBuilder.Model.Wall;

public abstract class AWall
{
    public string Material { get; init; }
    public double Height { get; init; }
    public double Length { get; init; }

    private readonly List<AWindow> _windows;
    public IEnumerable<AWindow> Windows => _windows;

    private readonly List<ADoor> _doors;
    public IEnumerable<ADoor> Doors => _doors;

    protected AWall(string material, double height, double length)
    {
        Material = material;
        Height = height;
        Length = length;

        _windows = new List<AWindow>();
        _doors = new List<ADoor>();
    }

    public void AddWindow(AWindow window)
    {
        _windows.Add(window);
    }

    public void AddDoor(ADoor door)
    {
        _doors.Add(door);
    }
}