using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Visitor
{
    public class VisitorContext
    {
        private readonly List<IElement> _elements;

        public VisitorContext()
        {
            _elements = new List<IElement>();
        }

        public void AddElement(IElement element)
        {
            _elements.Add(element);
        }
        
        public void Accept(IVisitor visitor)
        {
            foreach(var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
