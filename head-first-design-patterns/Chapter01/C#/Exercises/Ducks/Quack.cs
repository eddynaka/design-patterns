namespace Exercises.Ducks
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}