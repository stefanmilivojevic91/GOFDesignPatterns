using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        private readonly BaseCommand _command;

        public Invoker(BaseCommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }
    }
}
