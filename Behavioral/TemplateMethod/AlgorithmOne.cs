using System;

namespace GOFDesignPatterns.Behavioral.TemplateMethod
{
    public class AlgorithmOne : TemplateBase
    {
        public override void StepOne()
        {
            Console.WriteLine("Step one");
        }

        public override void StepTwo()
        {
            Console.WriteLine("Step two");
        }

        public override void StepThree()
        {
            Console.WriteLine("Step three");
        }
    }
}
