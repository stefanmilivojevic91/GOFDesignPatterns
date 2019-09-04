using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    public class TrancieverOne : ITranciever
    {
        private readonly IMediator _mediator;

        public TrancieverOne(IMediator mediator)
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
