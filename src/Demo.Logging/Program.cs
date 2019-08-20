using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using NLog;
using StackifyLib;
using Logger = NLog.Logger;

namespace Demo.Logging
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environmentName}.json", true, true)
                .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();
            configuration.ConfigureStackifyLogging();

            foreach (var index in Enumerable.Range(0, 10000))
            {
                Logger.Info($"{index}:  This is an informational message.");
                Logger.Error(new ArgumentException(nameof(args)));
            }

            Console.WriteLine("Hello World!  Hit ENTER...");
            Console.ReadLine();
        }
    }
}
