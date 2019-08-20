using System;
using Common.Logging.Simple;
using Demo.Logging.SharedLib;
using NLog;

namespace Demo.Logging.WithNLog
{
    class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Logger.Debug("Some Debug Log Output");
            new SharedObject().Execute();

            Console.ReadLine();
        }
    }
}
