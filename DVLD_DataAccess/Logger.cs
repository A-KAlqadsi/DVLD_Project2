using System;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    internal class Logger
    {
        public delegate void LogAction(string message, EventLogEntryType logType = EventLogEntryType.Error);

        LogAction _logAction;
        public Logger(LogAction logAction)
        {
            _logAction = logAction;
        }

        public void Log(string message, EventLogEntryType logType=EventLogEntryType.Error)
        {
            _logAction(message, logType);
        }

    }
    
}
