using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.ChainOfResponsability
{
    public class ConcreteHandler : HandlerBase
    {
        public override void HandleRequest(int type)
        {
            if (type == 1)
            {
                Console.WriteLine("Handled type 1");
            }

            if (_successor != null)
            {
                _successor.HandleRequest(type);
            }
        }
    }
}
