using log4net.Config;
using Ninject;
using Ninject.Extensions.Logging;
using Ninject.Modules;
using System.Collections.Generic;
using System.IO;

namespace Examples.NLogInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell Log4Net where the configuration file is
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

            IKernel kernel = new StandardKernel();
            kernel.Bind<IWeapon>().To<Sword>();
            var warrior1 = kernel.Get<Samurai>();
            warrior1.Attack("the evildoers");
        }
    }
}
