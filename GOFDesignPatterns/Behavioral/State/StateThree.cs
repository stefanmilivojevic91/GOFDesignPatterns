using System;

namespace GOFDesignPatterns.Behavioral.State
{
    public class StateThree : IState
    {
        public void Request(Context context)
        {
            Console.WriteLine("Perform action");
            context.SetState(new StateOne());
        }
    }
}
