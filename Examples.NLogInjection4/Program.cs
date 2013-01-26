using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.NLogInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IWeapon>().To<Sword>();

            var warrior1 = kernel.Get<Samurai>();
            warrior1.Attack("the evildoers");
        }
    }
}
