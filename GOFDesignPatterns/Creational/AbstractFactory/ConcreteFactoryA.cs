namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactoryA : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
