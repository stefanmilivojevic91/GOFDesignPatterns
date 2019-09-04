using GOFDesignPatterns.Creational.FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatters.Tests.Creational
{
    [TestClass]
    public class FactoryMethodTests
    {
        public FactoryMethodTests()
        {
        }

        [TestMethod]
        public void TestFactoryMethod()
        {
            IFactory factory = new ProductOneFactory();
            IProduct product = factory.BuildProduct();

            Assert.AreEqual(typeof(ConcreteProductOne), product.GetType());

            factory = new ProductTwoFactory();
            IProduct productTwo = factory.BuildProduct();

            Assert.AreEqual(typeof(ConcreteProductTwo), productTwo.GetType());
        }
    }
}
