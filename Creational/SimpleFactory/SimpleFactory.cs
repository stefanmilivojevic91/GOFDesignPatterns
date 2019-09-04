using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.SimpleFactory
{
    public static class SimpleFactory
    {
        public static IProduct CreateProduct(ProductType productType)
        {
            if (productType == ProductType.A)
            {
                return new ConcreteProductA();
            }
            else if (productType == ProductType.B)
            {
                return new ConcreteProductB();
            }
            else if (productType == ProductType.C)
            {
                return new ConcreteProductC();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
