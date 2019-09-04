using GOFDesignPatterns.Structural.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatters.Tests.Structural
{
    [TestClass]
    public class ProxyTests
    {
        public ProxyTests()
        {
        }

        [TestMethod]
        public void TestProxy()
        {
            var proxy = new Proxy();

            proxy.Method();
        }
    }
}
