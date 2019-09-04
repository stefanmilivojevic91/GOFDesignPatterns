using GOFDesignPatterns.Structural.Flyweight;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Structural
{
    [TestClass]
    public class FlyWeightTests
    {
        public FlyWeightTests()
        {
        }

        [TestMethod]
        public void TestFlyweight()
        {
            var flyweightFactory = new FlyweightFactory();

            var unsharedFlyWeightOne = new UnsharedFlyweight(flyweightFactory.GetObject("FlyWeightOne"));
            var unsharedFlyWeightTwo = new UnsharedFlyweight(flyweightFactory.GetObject("FlyWeightOne"));

            Assert.AreEqual(unsharedFlyWeightOne.GetState(), unsharedFlyWeightTwo.GetState());
        }
    }
}
