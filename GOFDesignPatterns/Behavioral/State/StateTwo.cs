using System;

namespace GOFDesignPatterns.Behavioral.State
{
    public class StateTwo : IState
    {
        public void Request(Context context)
        {
            Console.WriteLine("Perform action");
            context.SetState(new StateThree());
        }
    }
}
