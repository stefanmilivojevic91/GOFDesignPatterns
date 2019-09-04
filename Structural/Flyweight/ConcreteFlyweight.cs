using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Flyweight
{
    public class ConcreteFlyweight : FlyweightBase
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete operation!");
        }
    }
}
