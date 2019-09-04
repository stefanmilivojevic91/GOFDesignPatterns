using GOFDesignPatterns.Structural.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatters.Tests.Structural
{
    [TestClass]
    public class FacadeTests
    {
        public FacadeTests()
        {

        }

        [TestMethod]
        public void TestFacade()
        {
            Facade facade = new Facade();

            facade.Method();
        }
    }
}
