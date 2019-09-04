using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        void BuildPartOne(string parameterOne);
        void BuildPartTwo(string parameterTwo);
        void BuildPartThree(string parameterThree);
        Product GetProduct();
    }
}
