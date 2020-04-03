namespace Exercises.Ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I'm flying");
        }
    }
}