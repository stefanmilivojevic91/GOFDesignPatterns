using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Command
{
    public class Receiver
    {
        public void Action(string message)
        {
            Console.WriteLine(message);
        }
    }
}
