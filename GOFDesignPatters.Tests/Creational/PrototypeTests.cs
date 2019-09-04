using GOFDesignPatterns.Creational.Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Creational
{
    [TestClass]
    public class PrototypeTests
    {
        public PrototypeTests()
        {
        }

        [TestMethod]
        public void TestPrototype()
        {
            var prototype = new Prototype
            {
                Name = "Test"
            };

            var clone = (Prototype)prototype.Clone();

            Assert.AreEqual(prototype.Name, clone.Name);
        }
    }
}
