using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(ConcreteElementOne element);
        void Visit(ConcreteElementTwo element);
    }
}
