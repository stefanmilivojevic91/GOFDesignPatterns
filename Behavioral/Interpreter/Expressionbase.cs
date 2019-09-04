using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Interpreter
{
    public abstract class Expressionbase
    {
        public abstract void Interpret(string context);
    }
}
