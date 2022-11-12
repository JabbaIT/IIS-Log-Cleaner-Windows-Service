using System;

namespace IISLogsCleanerService
{
    public class ServiceFunctions
    {

        /// <summary>
        /// Convert Hours into Milliseconds
        /// </summary>
        /// <param name="hours"></param>
        /// <returns>Milliseconds</returns>
        public static int ConvertHoursToMilliseconds(int hours)
        {
            return (int)TimeSpan.FromHours(hours).TotalMilliseconds;
        }

        /// <summary>
        /// Calaculte the Age of the file
        /// </summary>
        /// <param name="lastModified"></param>
        /// <returns>Age of the file</returns>
        public static TimeSpan getFileAge(System.DateTime lastModified)
        {
            //Calculate the Age of the File
            TimeSpan difference = DateTime.Now.Date - lastModified.Date;
            return difference;
        }
    }
}
