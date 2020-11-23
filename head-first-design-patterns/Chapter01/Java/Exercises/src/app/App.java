package app;

import ducks.Duck;
import ducks.FlyRocketPowered;
import ducks.MallardDuck;
import ducks.ModelDuck;
import people.Queen;
import people.Character;

public class App {
    public static void main(String[] args) throws Exception {
        Duck mallard = new MallardDuck();
        mallard.performQuack();
        mallard.performFly();

        Duck model = new ModelDuck();
        model.performFly();
        model.setFlyBehavior(new FlyRocketPowered());
        model.performFly();

        Character queen = new Queen();
        queen.fight();
    }
}