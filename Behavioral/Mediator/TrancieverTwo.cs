using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    public class TrancieverTwo : ITranciever
    {
        private readonly IMediator _mediator;

        public TrancieverTwo(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendMessage(string message)
        {
            _mediator.Send(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
