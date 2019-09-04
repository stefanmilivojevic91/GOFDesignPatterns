using System;

namespace GOFDesignPatterns.Behavioral.Interpreter
{
    public class TerminalExpression : Expressionbase
    {
        public override void Interpret(string context)
        {
            Console.WriteLine(context);
        }
    }
}
