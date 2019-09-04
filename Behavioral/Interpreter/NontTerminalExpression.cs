using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Behavioral.Interpreter
{
    public class NontTerminalExpression : Expressionbase
    {
        public Expressionbase ExpressionOne { get; set; }
        public Expressionbase ExpressionTwo { get; set; }

        public override void Interpret(string context)
        {
            ExpressionOne.Interpret(context);
            ExpressionTwo.Interpret(context);
        }
    }
}
