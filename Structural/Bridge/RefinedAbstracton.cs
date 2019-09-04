using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementation implementer) : base(implementer)
        {

        }

        public override string Operation()
        {
            return _implementer.Operation();
        }
    }
}
