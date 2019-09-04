using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Command
{
    public class Command : BaseCommand
    {
        public string Message { get; set; }

        public Command(Receiver receiver) : base(receiver)
        {

        }

        public override void Execute()
        {
            _receiver.Action(Message);
        }
    }
}
