package people;

public abstract class Character {
    WeaponBehavior weapon;

    public Character() {
        super();
    }

    public void fight() {
        weapon.useWeapon();
    }

    public void setWeapon(WeaponBehavior wb) {
        weapon = wb;
    }
}