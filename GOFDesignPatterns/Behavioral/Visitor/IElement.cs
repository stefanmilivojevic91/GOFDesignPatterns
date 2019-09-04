using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
