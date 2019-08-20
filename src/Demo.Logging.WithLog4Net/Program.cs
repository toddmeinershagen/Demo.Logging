using System;
using Common.Logging.Log4Net.Universal;
using Demo.Logging.SharedLib;
using log4net;

namespace Demo.Logging.WithLog4Net
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            // set logger factory
            Common.Logging.LogManager.Adapter = new Log4NetFactoryAdapter();

            // log something
            Logger.Debug("Some Debug Log Output");

            new SharedObject().Execute();

            Console.ReadLine();
        }
    }
}
