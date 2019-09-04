using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, FlyweightBase> _objects;

        public FlyweightFactory()
        {
            _objects = new Dictionary<string, FlyweightBase>();
        }

        public FlyweightBase GetObject(string type)
        {
            if (_objects.ContainsKey(type))
            {
                return _objects[type];
            }

            var concreteFlyweight = new ConcreteFlyweight();

            _objects[type] = concreteFlyweight;

            return concreteFlyweight;
        }
    }
}
