using System;
using System.Configuration;
using Topshelf;
using static IISLogsCleanerService.IISLogCleanerService;

namespace IISLogsCleanerService
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                //Service Call
                x.Service<IISLogCleanerService>(s => {
                    s.ConstructUsing(iisLogCleaner => new IISLogCleanerService());
                    s.WhenStarted(iisLogsCleaner => iisLogsCleaner.Start());
                    s.WhenStopped(iisLogsCleaner => iisLogsCleaner.Stop());
                });

                //Run as local System
                x.RunAsLocalSystem();

                //Service Configuration 
                x.SetServiceName(ConfigurationManager.AppSettings["ServiceName"]);
                x.SetDisplayName(ConfigurationManager.AppSettings["ServiceDisplayName"]);
                x.SetDescription(ConfigurationManager.AppSettings["ServiceDescription"]);

                //Configure Recovery Options for the Service
                x.EnableServiceRecovery(ro =>
                {
                    ro.RestartService(1);
                    ro.RestartService(1);
                    ro.RestartService(1);
                    ro.SetResetPeriod(1);
                });

                //Install Options
                x.AfterInstall(() =>
                {
                   AfterInstall(ConfigurationManager.AppSettings["AppLogSourceName"].ToString());
                });

                //Uninstall Options
                x.AfterUninstall(() =>
                {
                    AfterUninstall(ConfigurationManager.AppSettings["AppLogSourceName"].ToString());
                });

                //Allow the Service to be shutdown
                x.EnableShutdown();

                //Start up type
                x.StartManually();
                
            });
            
            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue; 

        }
    }
}
