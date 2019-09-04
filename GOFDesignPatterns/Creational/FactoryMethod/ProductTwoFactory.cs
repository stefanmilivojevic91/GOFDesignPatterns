using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.FactoryMethod
{
    public class ProductTwoFactory : IFactory
    {
        public IProduct BuildProduct()
        {
            return new ConcreteProductTwo();
        }
    }
}
