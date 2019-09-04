using System;
using System.Collections.Generic;

namespace GOFDesignPatterns.Structural.Composite
{
    public class Component : IComponent
    {
        private ICollection<IComponent> _subordinates;

        public Component()
        {
            _subordinates = new List<IComponent>();
        }

        public void AddChild(IComponent component)
        {
            _subordinates.Add(component);
        }

        public void Operation()
        {
            Console.WriteLine("Test");

            foreach(var component in _subordinates)
            {
                component.Operation();
            }
        }
    }
}
