namespace GOFDesignPatterns.Creational.Singleton
{
    public sealed class EagerSingleton
    {
        private EagerSingleton()
        {

        }

        public static EagerSingleton Instance { get; } = new EagerSingleton();
    }
}
