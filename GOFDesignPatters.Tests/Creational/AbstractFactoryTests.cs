using GOFDesignPatterns.Creational.AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatters.Tests.Creational
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            IAbstractFactory factory = new ConcreteFactoryA();

            var productA1 = factory.CreateProductA();
            var productB1 = factory.CreateProductB();

            Assert.AreEqual(productA1.GetType(), typeof(ProductA1));
            Assert.AreEqual(productB1.GetType(), typeof(ProductB1));

            factory = new ConcreteFactoryB();

            var productA2 = factory.CreateProductA();
            var productB2 = factory.CreateProductB();

            Assert.AreEqual(productA2.GetType(), typeof(ProductA2));
            Assert.AreEqual(productB2.GetType(), typeof(ProductB2));
        }
    }
}
