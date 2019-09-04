using GOFDesignPatterns.Structural.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatters.Tests.Structural
{
    public class DecoratorTests
    {
        public DecoratorTests()
        {

        }

        [TestMethod]
        public void TestDecorator()
        {
            DecoratorComponentBase component = new DecoratorComponent();

            component.Operation();

            ConcreteDecorator decorator = new ConcreteDecorator(component);

            decorator.Operation();
        }
    }
}
