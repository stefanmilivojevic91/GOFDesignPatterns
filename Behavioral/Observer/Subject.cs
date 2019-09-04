using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Observer
{
    public class Subject
    {
        private List<Observer> _observers;
        private string _state;

        public Subject()
        {
            _observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Update();
            }
        }

        public string State
        {
            set
            {
                _state = value;
                Notify();
            }
            get
            {
                return _state;
            }
        }
    }
}
