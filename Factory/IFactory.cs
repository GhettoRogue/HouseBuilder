using HouseBuilder.Factory.FoundationFactory;

namespace HouseBuilder.Factory;

public interface IFactory<out T>
{
    public T Create();
}