using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : IMediator
    {
        public ITranciever TrancieverOne { get; set; }
        public ITranciever TrancieverTwo { get; set; }

        public void Send(ITranciever caller, string message)
        {
            if (caller is TrancieverOne)
            {
                TrancieverOne.ReceiveMessage(message);
            }
            else if (caller is TrancieverTwo)
            {
                TrancieverTwo.ReceiveMessage(message);
            }
        }
    }
}
