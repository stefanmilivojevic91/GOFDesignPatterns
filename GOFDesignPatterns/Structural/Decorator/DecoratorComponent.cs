using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Decorator
{
    public class DecoratorComponent : DecoratorComponentBase
    {
        public override void Operation()
        {
            Console.WriteLine("Component to be decorated.");
        }
    }
}
