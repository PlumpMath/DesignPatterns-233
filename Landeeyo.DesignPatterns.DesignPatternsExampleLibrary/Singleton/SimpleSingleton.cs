
namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Singleton
{
    public sealed class SimpleSingleton
    {
        private static readonly SimpleSingleton instance = new SimpleSingleton();

        private SimpleSingleton() { }

        public static SimpleSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public static string Execute()
        {
            return "It's me, singleton!";
        }
    }
}