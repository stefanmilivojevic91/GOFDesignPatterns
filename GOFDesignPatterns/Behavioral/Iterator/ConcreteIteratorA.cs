using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Iterator
{
    public class ConcreteIteratorA : IIterator
    {
        private readonly ConcreteAggregateA _aggregate;
        private int _position;

        public ConcreteIteratorA(ConcreteAggregateA aggregate)
        {
            _aggregate = aggregate;
            _position = 0;
        }

        public object Current()
        {
            if (_position < _aggregate.Count())
            {
                return _aggregate[_position];
            }

            return null;
        }

        public object Next()
        {
            _position++;
            return Current();
        }

        public bool IsDone()
        {
            return _position == _aggregate.Count();
        }
    }
}
