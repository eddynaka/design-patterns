package ducks;

public class MallardDuck extends Duck {

    public MallardDuck() {
        super();

        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    @Override
    public void display() {
        System.out.println("I'm a real mallard duck");
    }

}