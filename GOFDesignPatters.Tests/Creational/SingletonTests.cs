using GOFDesignPatterns.Creational.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatters.Tests.Creational
{
    [TestClass]
    public class SingletonTests
    {
        public SingletonTests()
        {
        }

        [TestMethod]
        public void TestEagerSingleton()
        {
            var instanceOne = EagerSingleton.Instance;
            var instanceTwo = EagerSingleton.Instance;

            Assert.AreEqual(instanceOne, instanceTwo);
        }

        [TestMethod]
        public void TestLazySingleton()
        {
            var instanceOne = LazySingleton.Instance();
            var instanceTwo = LazySingleton.Instance();

            Assert.AreEqual(instanceOne, instanceTwo);
        }
    }
}
