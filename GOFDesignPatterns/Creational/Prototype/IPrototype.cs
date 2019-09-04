using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
