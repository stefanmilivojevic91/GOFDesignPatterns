using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        bool IsDone();
        object Current();
        object Next();
    }
}
