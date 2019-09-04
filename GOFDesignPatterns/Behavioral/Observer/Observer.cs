using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Observer
{
    public class Observer
    {
        private readonly Subject _subject;

        public Observer(Subject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine(_subject.State);
        }
    }
}
