using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ConcreteElementOne element)
        {
            Console.WriteLine(element.Property);
        }

        public void Visit(ConcreteElementTwo element)
        {
            Console.WriteLine(element.Property);
        }
    }
}
