using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Iterator
{
    public interface IAggregate
    {
        IIterator GetIterator();
    }
}
