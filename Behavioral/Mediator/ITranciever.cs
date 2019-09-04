using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Mediator
{
    public interface ITranciever
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
