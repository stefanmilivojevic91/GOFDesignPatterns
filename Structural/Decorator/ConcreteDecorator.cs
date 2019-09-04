using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Decorator
{
    public class ConcreteDecorator : DecoratorBase
    {
        public ConcreteDecorator(DecoratorComponentBase component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Decorated method!");
        }
    }
}
