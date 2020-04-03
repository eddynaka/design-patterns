namespace Exercises.Ducks
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("<< silence >>");
        }
    }
}