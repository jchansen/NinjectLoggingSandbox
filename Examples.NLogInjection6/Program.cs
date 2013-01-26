using log4net.Config;
using Ninject;
using Ninject.Extensions.Logging;
using Ninject.Extensions.Logging.NLog2.Infrastructure;
using Ninject.Modules;
using System.Collections.Generic;
using System.IO;

namespace Examples.NLogInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // If the NLog and Log4Net extensions are both included in the project,
            // they will both register themselves.  This will confuse Ninject because
            // it will see multiple factories for producing ILoggers
            //
            // NLog Extension: https://github.com/ninject/ninject.extensions.logging/blob/master/src/Ninject.Extensions.Logging.NLog2/NLogModule.cs
            //  public class NLogModule : LoggerModuleBase
            //  {
            //      public override void Load()
            //      {
            //          this.Bind<ILoggerFactory>().ToConstant(new NLogLoggerFactory());
            //          base.Load();
            //      }
            //  }
            //
            // Log4Net Extension: https://github.com/ninject/ninject.extensions.logging/blob/master/src/Ninject.Extensions.Logging.Log4Net/Log4netModule.cs
            //  public class Log4NetModule : LoggerModuleBase
            //  {
            //      public override void Load()
            //      {
            //          this.Bind<ILoggerFactory>().ToConstant(new Log4NetLoggerFactory());
            //          base.Load();
            //      }
            //  }

            // To fix this, you need to unload one of the assemblies from the kernel
            // though in reality, it seems unlikely you would keep both assemblies in
            // the project.
            IKernel kernel = new StandardKernel();

            bool useNLog = false;
            if (useNLog)
            {
                // Unload the Log4NetModule to remove duplicate binding
                kernel.Unload("Ninject.Extensions.Logging.Log4net.Log4NetModule");
            }
            else // use Log4Net
            {
                // Tell Log4Net where the configuration file is
                XmlConfigurator.Configure(new FileInfo("log4net.config"));

                // Unload the NLogModule to remove duplicate binding
                kernel.Unload("Ninject.Extensions.Logging.NLog2.NLogModule");
            }
            
            kernel.Bind<IWeapon>().To<Sword>();
            var warrior1 = kernel.Get<Samurai>();
            warrior1.Attack("the evildoers");
        }
    }
}
