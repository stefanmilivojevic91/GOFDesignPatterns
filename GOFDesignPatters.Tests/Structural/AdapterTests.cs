using GOFDesignPatterns.Structural.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatters.Tests.Structural
{
    [TestClass]
    public class AdapterTests
    {
        public AdapterTests()
        {
        }

        [TestMethod]
        public void TestAdapter()
        {
            ITarget target = new Adapter();

            var result = target.Method();

            Assert.AreEqual(result, "Test");
        }
    }
}
