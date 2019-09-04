using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Adapter
{
    public class Adaptee
    {
        public string IncompatibleMethod()
        {
            return "Test";
        }
    }
}
