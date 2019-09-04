namespace GOFDesignPatterns.Behavioral.TemplateMethod
{
    public abstract class TemplateBase
    {
        public void CallAlgorithm()
        {
            StepOne();
            StepTwo();
            StepThree();
        }

        public abstract void StepOne();
        public abstract void StepTwo();
        public abstract void StepThree();
    }
}
