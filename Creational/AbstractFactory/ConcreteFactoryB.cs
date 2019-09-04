
namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactoryB : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
