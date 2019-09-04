using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Bridge
{
    public abstract class Abstraction
    {
        protected IImplementation _implementer;

        protected Abstraction(IImplementation implementer)
        {
            _implementer = implementer;
        }

        public virtual string Operation()
        {
            return _implementer.Operation();
        }
    }
}
