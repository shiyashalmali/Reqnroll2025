﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject2025.Utilities
{
    internal class Log
    {
        private static readonly string logFile = "TestLog.txt";

        public static void Info(string message)
        {
            File.AppendAllText(logFile, $"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
        }
    }
}
