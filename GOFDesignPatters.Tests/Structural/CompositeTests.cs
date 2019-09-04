using GOFDesignPatterns.Structural.Composite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Structural
{
    [TestClass]
    public class CompositeTests
    {
        public CompositeTests()
        {
        }

        [TestMethod]
        public void TestComposite()
        {
            var rootComponent = new Component();
            var component1 = new Component();
            var component2 = new Component();
            var leafComponent1 = new LeafComponent();
            var leafComponent2 = new LeafComponent();

            rootComponent.AddChild(component1);
            rootComponent.AddChild(component2);
            component1.AddChild(leafComponent1);
            component2.AddChild(leafComponent2);

            rootComponent.Operation();
        }
    }
}
