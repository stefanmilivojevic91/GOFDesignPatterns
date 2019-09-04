namespace GOFDesignPatterns.Creational.Singleton
{
    public sealed class LazySingleton
    {
        private static LazySingleton _instance;

        private LazySingleton()
        {
        }

        public static LazySingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new LazySingleton();
            }

            return _instance;
        }
    }
}
