using System.Threading;

namespace GOFDesignPatterns.Creational.Prototype
{
    public class Prototype : IPrototype
    {
        public string Name { get; set; }

        public Prototype()
        {
            Thread.Sleep(10);
        }

        public IPrototype Clone()
        {
            return (IPrototype) MemberwiseClone();
        }
    }
}
