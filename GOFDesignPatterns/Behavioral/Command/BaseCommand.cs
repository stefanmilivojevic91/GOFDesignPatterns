using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Command
{
    public abstract class BaseCommand
    {
        protected readonly Receiver _receiver;

        protected BaseCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}
