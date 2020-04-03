namespace Exercises.Ducks {
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}