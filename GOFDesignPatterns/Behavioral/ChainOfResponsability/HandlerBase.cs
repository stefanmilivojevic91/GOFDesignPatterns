using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.ChainOfResponsability
{
    public abstract class HandlerBase
    {
        protected HandlerBase _successor;

        public void SetSuccessor(HandlerBase successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int type);
    }
}
