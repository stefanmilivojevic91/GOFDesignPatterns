using GOFDesignPatterns.Creational.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Creational
{
    [TestClass]
    public class BuilderTests
    {
        public BuilderTests()
        {
        }

        [TestMethod]
        public void TestBuilder()
        {
            IBuilder builder = new ConcreteBuilder();

            builder.BuildPartOne("Part 1");
            builder.BuildPartTwo("Part 2");
            builder.BuildPartThree("Part 3");

            var product = builder.GetProduct();

            Assert.AreEqual(product.PartOne, "Part 1");
            Assert.AreEqual(product.PartTwo, "Part 2");
            Assert.AreEqual(product.PartThree, "Part 3");
        }

        [TestMethod]
        public void TestStaticNestedBuilder()
        {
            var product = new StaticNestedBuilder.Builder()
                .SetPartOne("Part 1")
                .SetPartTwo("Part 2")
                .SetPartThree("Part 3")
                .Build();

            Assert.AreEqual(product.PartOne, "Part 1");
            Assert.AreEqual(product.PartTwo, "Part 2");
            Assert.AreEqual(product.PartThree, "Part 3");
        }
    }
}
