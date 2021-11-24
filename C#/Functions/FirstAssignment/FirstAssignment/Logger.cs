using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    static class Logger
    {

        public static void WriteLog(string message, string kind)
        {
            string logpath = $"c:/TestLogs/{kind}log.txt";

            using (StreamWriter writer = new StreamWriter(logpath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
