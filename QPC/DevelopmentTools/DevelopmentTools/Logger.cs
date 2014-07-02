using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Appender;
using log4net.Layout;
using log4net.Core;
using System.IO;
namespace DevelopmentTools
{
    //Obfuscator used on this assembly - check the ObfuscatedAssembly folder
    class Logger
    {
        private static readonly ILog log =
            LogManager.GetLogger(typeof(Logger));

        static void Main()
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "log.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.Threshold = Level.Warn;
            fileAppender.ActivateOptions();
            BasicConfigurator.Configure(fileAppender);

            try
            {
                File.ReadAllLines(@"124334325.txt");
            }
            catch (FileNotFoundException ex)
            {
                log.Fatal(ex);
            }
            log.Info("Some info");
            log.Warn("Warning!");
        }
    }
}
