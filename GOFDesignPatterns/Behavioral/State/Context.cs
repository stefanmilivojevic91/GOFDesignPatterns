using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.State
{
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Request(this);
        }

        public void SetState(IState newState)
        {
            _state = newState;
        }
    }
}
