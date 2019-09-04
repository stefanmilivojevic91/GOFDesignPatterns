using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Decorator
{
    public abstract class DecoratorBase : DecoratorComponentBase
    {
        private readonly DecoratorComponentBase _component;

        protected DecoratorBase(DecoratorComponentBase component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }
}
