using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public string Method()
        {
            return _adaptee.IncompatibleMethod();
        }
    }
}
