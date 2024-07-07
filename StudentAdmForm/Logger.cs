using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmForm
{
    public enum LogLevel
    {
        Info,
        Error
    }
    internal class Logger
    {
        private static readonly string logDirectory = @"C:\Logs";
        private static readonly string logFilePath = Path.Combine(logDirectory, "application.log");

        static Logger()
        {
            // Ensure the log directory exists
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        public static void Log(LogLevel level, string message)
        {
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";

            // Write log to file
            try
            {
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(logLine);
                }
            }
            catch (Exception ex)
            {
                // Handle exception if logging fails
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }

}
