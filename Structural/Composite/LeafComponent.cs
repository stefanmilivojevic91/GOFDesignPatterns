using System;

namespace GOFDesignPatterns.Structural.Composite
{
    public class LeafComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Test from leaf component");
        }
    }
}
