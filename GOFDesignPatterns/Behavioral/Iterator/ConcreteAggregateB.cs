using System;
using System.Collections.Generic;

namespace GOFDesignPatterns.Behavioral.Iterator
{
    public class ConcreteAggregateB : IAggregate
    {
        private List<object> _items = new List<object>();

        public IIterator GetIterator()
        {
            return new ConcreteIteratorB(this);
        }

        public object this[int index]
        {
            get { return _items[index]; }
        }

        public int Count()
        {
            return _items.Count;
        }

        public void Add(object item)
        {
            _items.Add(item);
        }
    }
}
