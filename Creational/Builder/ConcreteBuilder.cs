using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product;

        public ConcreteBuilder()
        {
            _product = new Product();
        }

        public void BuildPartOne(string parameterOne)
        {
            _product.PartOne = parameterOne;
        }

        public void BuildPartTwo(string parameterTwo)
        {
            _product.PartTwo = parameterTwo;
        }

        public void BuildPartThree(string parameterThree)
        {
            _product.PartThree = parameterThree;
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
