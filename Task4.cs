using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8DZStreamAndBuffering
{
    class Task4
    {
        public static void TaskFour()
        {
            string str = "SomeText in somefile";

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Games\data.data"))
            {
                streamWriter.Write(str);
            }
        }
    }
}
