using System;
using System.Collections;

namespace GOFDesignPatterns.Behavioral.Iterator
{
    public class ConcreteAggregateA : IAggregate
    {
        private ArrayList _items = new ArrayList();

        public IIterator GetIterator()
        {
            return new ConcreteIteratorA(this);
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
