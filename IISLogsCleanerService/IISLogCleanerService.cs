using System;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Timers;
using static IISLogsCleanerService.ServiceFunctions;

namespace IISLogsCleanerService
{
    class IISLogCleanerService
    {
        //Private Properites
        private readonly Timer _timer;
        private static string _serviceName = ConfigurationManager.AppSettings["ServiceName"];        
        private static string _eventSourceName = ConfigurationManager.AppSettings["AppLogSourceName"];
        private static string _directoryPath = ConfigurationManager.AppSettings[@"DirectoryPath"];
        private static string _fileExtension = ConfigurationManager.AppSettings["FileExtension"];
        private static string _daysToKeep = ConfigurationManager.AppSettings["DaysToKeep"];
        private int _interval = Convert.ToInt32(ConfigurationManager.AppSettings["RunInterval"]);

        public IISLogCleanerService()
        {                                    
            _timer = new Timer(ConvertHoursToMilliseconds(_interval)) { AutoReset = true };            
            _timer.Elapsed += TimerElapsed; 
        }           

        public void TimerElapsed(object sender, ElapsedEventArgs e)
        {

            //Get a list of Files
            string[] files = Directory.GetFiles(@_directoryPath, _fileExtension, SearchOption.AllDirectories); 

            //Iterate through the files
            foreach (string f in files)
            {
                //Get the File
                FileInfo file = new FileInfo(f);

                //Get the Age of the file
                TimeSpan fileAge = getFileAge(file.LastWriteTimeUtc);

                //Can the file be deleted?
                if (fileAge.Days > Convert.ToInt64(_daysToKeep)) {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to delete " + ex.Message);
                    }
                }                
            }           
        }
       
        public static void AfterInstall(string v)
        {
            //Write Log Entry to Event Viewer -> Application Logs
            EventLog.WriteEntry(_eventSourceName, "Service " + _serviceName + " Installed", EventLogEntryType.Information, 1100);
        }

        public static void AfterUninstall(string v)
        {
            //Write Log Entry to Event Viewer -> Application Logs
            EventLog.WriteEntry(_eventSourceName, "Service " + _serviceName + " Uninstall", EventLogEntryType.Warning, 1101);
        }

        public void Start()
        {
            _timer.Start();            
        }

        public void Stop()
        {
            _timer.Stop();            
        }
    }
}
