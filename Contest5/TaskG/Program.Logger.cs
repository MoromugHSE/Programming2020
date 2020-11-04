using System;
using System.IO;

public partial class Program
{
    public static bool ParseCommandsCount(string input, out int count)
    {
        return int.TryParse(input, out count) && count > 0;
    }

    public class Logger
    {
        private string[] logs = new string[0];

        private const string FilePath = "logs.log";

        private static Logger logger = new Logger();

        public static Logger GetLogger()
        {
            return logger;
        }

        private void AddLog(string text)
        {
            Array.Resize(ref logs, logs.Length + 1);
            logs[logs.Length - 1] = text;
        }

        private void DeleteLastLog()
        {
            if (logs.Length == 0)
            {
                File.AppendAllLines(FilePath, new string[] { "No active logs" });
                return;
            }
            logs[logs.Length - 1] = null;
            Array.Resize(ref logs, logs.Length - 1);
        }

        private void WriteAllLogs()
        {
            if (logs.Length == 0)
            {
                File.AppendAllLines(FilePath, new string[] { "No active logs" });
                return;
            }
            File.AppendAllLines(FilePath, logs);
            logs = new string[0];
        }

        public static void HandleCommand(string command)
        {
            switch(command[0])
            {
                case 'A':
                    {
                        logger.AddLog(command.Substring(8, command.Length-8-1));
                        return;
                    }
                case 'D':
                    {
                        logger.DeleteLastLog();
                        return;
                    }
                case 'W':
                    {
                        logger.WriteAllLogs();
                        return;
                    }
            }
        }
    }

}