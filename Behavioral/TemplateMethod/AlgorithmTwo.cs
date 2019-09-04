using System;

namespace GOFDesignPatterns.Behavioral.TemplateMethod
{
    public class AlgorithmTwo : TemplateBase
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
