using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.MultipleInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new TestModule());

            var warrior1 = kernel.Get<Samurai>();
            warrior1.Attack("the evildoers");
        }
    }

    class TestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>();
            Bind<IWeapon>().To<Shuriken>();
        }
    }
}
