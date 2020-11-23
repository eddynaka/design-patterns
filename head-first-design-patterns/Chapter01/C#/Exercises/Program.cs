using System;
using Exercises.Ducks;
using Exercises.People;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Character queen = new Queen();
            queen.Fight();
        }
    }
}
