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
        string[] logs;
        private static Logger logger;

        public static Logger GetLogger()
        {
            throw new NotImplementedException();
        }

        public static void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }
    }

}