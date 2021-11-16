using System;
using System.IO;

namespace Lesson5_2
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileName = "startup.txt";
            DateTime now = DateTime.Now;
            File.AppendAllText(fileName, (now + Environment.NewLine));
        }
    }
}
