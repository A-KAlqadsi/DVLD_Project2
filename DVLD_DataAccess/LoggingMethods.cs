using System;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    internal class LoggingMethods
    {
        public static void EventLogger(string message, EventLogEntryType logType)
        {
            string sourceName = "DVLD_App";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            // Log an information event
            EventLog.WriteEntry(sourceName, message, logType);

        }
    }
}
