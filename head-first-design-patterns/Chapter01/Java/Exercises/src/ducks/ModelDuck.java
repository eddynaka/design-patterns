package ducks;

public class ModelDuck extends Duck {

    public ModelDuck() {
        super();

        flyBehavior = new FlyNoWay();
        quackBehavior = new Quack();
    }

    @Override
    public void display() {
        System.out.println("I'm a model duck");
    }

}