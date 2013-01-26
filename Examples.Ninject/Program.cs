using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IWeapon>().To<Sword>();

            var warrior1 = kernel.Get<Samurai>();
            var warrior2 = new Samurai(new Sword());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");
        }
    }

}
