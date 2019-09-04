using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Flyweight
{
    public class UnsharedFlyweight : FlyweightBase
    {
        private object _state;

        public UnsharedFlyweight(object state)
        {
            _state = state;
        }

        public object GetState()
        {
            return _state;
        }

        public override void Operation()
        {
            Console.WriteLine(_state);
        }
    }
}
