using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.FactoryMethod
{
    public interface IFactory
    {
        IProduct BuildProduct();
    }
}
