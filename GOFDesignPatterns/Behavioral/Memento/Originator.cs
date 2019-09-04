using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private object _state;

        public Originator(object state)
        {
            _state = state;
        }

        public Memento CreateMemento()
        {
            return new Memento
            {
                State = _state
            };
        }

        public void SetMemento(Memento memento)
        {
            _state = memento.State;
        }
    }
}
