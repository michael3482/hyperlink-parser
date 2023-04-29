using System;
using System.IO;

namespace URL
{
    internal class Logs
    {
        public static void Add(string message)
        {
            using (StreamWriter file = new StreamWriter("logs.txt", true))
            {
                message = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] " + message;
                file.WriteLine(message);
            }
        }
    }
}
