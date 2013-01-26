using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.MultipleInjection
{
    class Samurai
    {
        readonly List<IWeapon> weapons;

        public Samurai(List<IWeapon> weapons)
        {
            this.weapons = weapons;
        }

        public void Attack(string target)
        {
            foreach (var weapon in weapons)
            {
                weapon.Hit(target);
            }
            
        }
    }
}
