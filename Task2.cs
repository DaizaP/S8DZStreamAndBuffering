using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8DZStreamAndBuffering
{
    class Task2
    {
        public static void TaskTwo()
        {
            string path = @"C:\Users\Дмитрий\Desktop\test2.txt";

            if (File.Exists(path))
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string str = "";
                    while (!sr.EndOfStream)
                    {
                        str += sr.ReadLine() + "\n";
                    }
                    Console.WriteLine(str);
                }

            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
