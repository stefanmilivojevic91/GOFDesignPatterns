using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.FactoryMethod
{
    public class ProductOneFactory : IFactory
    {
        public IProduct BuildProduct()
        {
            return new ConcreteProductOne();
        }
    }
}
