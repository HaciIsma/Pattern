namespace Singleton_Pattern.Model
{
    public class Singleton
    {
        private static Singleton singleton;

        public static Singleton GetSingleton
        {
            get => singleton ??= new Singleton();
        }

        public void Smth()
        {
            System.Console.WriteLine("Smth");
        }
    }
}
