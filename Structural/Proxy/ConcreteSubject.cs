using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Proxy
{
    public class ConcreteSubject : SubjectBase
    {
        public override void Method()
        {
            Console.WriteLine("Method called.");
        }
    }
}
