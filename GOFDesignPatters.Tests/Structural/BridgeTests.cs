using GOFDesignPatterns.Structural.Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Structural
{
    [TestClass]
    public class BridgeTests
    {
        public BridgeTests()
        {
        }

        [TestMethod]
        public void TestBridge()
        {
            IImplementation implementer = new ConcreteImplementation();

            var abstraction = new RefinedAbstraction(implementer);

            var result = abstraction.Operation();

            Assert.AreEqual(result, "Test");
        }
    }
}
