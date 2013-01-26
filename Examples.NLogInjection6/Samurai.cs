
namespace Examples.NLogInjection
{
    class Samurai
    {
        readonly IWeapon weapon;

        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
