using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8DZStreamAndBuffering
{
    class Task1
    {
        public static void OneTask()
        {
            using (FileStream fileStream = new FileStream(@"C:\Users\Дмитрий\Desktop\test.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fileStream);
                Console.WriteLine(sr.CurrentEncoding);
                byte[] bytes = new byte[fileStream.Length];
                int count = fileStream.Read(bytes);

                if (count == fileStream.Length)
                {
                    string str = Encoding.UTF8.GetString(bytes);
                    Console.WriteLine(str);
                }
            }
        }
    }
}
