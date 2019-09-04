using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Send(ITranciever caller, string message);
    }
}
