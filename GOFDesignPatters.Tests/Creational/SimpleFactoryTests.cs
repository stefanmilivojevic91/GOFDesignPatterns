using GOFDesignPatterns.Creational.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Creational
{
    [TestClass]
    public class SimpleFactoryTests
    {
        public SimpleFactoryTests()
        {
        }

        [TestMethod]
        public void TestSimpleFactory()
        {
            IProduct producA = SimpleFactory.CreateProduct(ProductType.A);
            IProduct productB = SimpleFactory.CreateProduct(ProductType.B);
            IProduct productC = SimpleFactory.CreateProduct(ProductType.C);

            Assert.AreEqual(producA.GetType(), typeof(ConcreteProductA));
            Assert.AreEqual(productB.GetType(), typeof(ConcreteProductB));
            Assert.AreEqual(productC.GetType(), typeof(ConcreteProductC));
        }
    }
}
