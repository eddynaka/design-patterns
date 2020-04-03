namespace Exercises.People
{
    public abstract class Character
    {
        public IWeaponBehavior weapon;

        public void Fight()
        {
            weapon.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior wb)
        {
            weapon = wb;
        }
    }
}