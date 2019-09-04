using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Facade
{
    public class Facade
    {
        private readonly SubSystemOne _subSystemOne;
        private readonly SubSystemTwo _subSystemTwo;
        private readonly SubSystemThree _subSystemThree;

        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
        }

        public void Method()
        {
            _subSystemOne.Method();
            _subSystemTwo.Method();
            _subSystemThree.Method();
        }
    }
}
