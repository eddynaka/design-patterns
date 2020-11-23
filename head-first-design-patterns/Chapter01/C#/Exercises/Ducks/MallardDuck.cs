namespace Exercises.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            System.Console.WriteLine("I'm a real mallard duck");
        }
    }
}