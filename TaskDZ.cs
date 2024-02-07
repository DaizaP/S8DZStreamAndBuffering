using System.Text;

namespace S8DZStreamAndBuffering
{
    class TaskDZ
    {
        public static void TaskHomerork(string format, string textInFile)
        {
            //Пробегаемся по всем дискам
            string[] DriveArr = Environment.GetLogicalDrives();
            List<string> resPath = new List<string>();
            foreach (string path in DriveArr)
            {
                FindFile(format, path, textInFile, resPath);
            }
            foreach (string path in resPath)
            {
                if (path != "NULL") { Console.WriteLine(path); }
            }
            
        }
        static string FindFile(string format, string dir, string textInFile, List<string> stringsPath)
        {
            //Игнорируем директории к которым нет доступа
            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true,
            };
            foreach (string name in Directory.GetFiles(dir, "*", options))
            {
                if (Path.GetExtension(name) == format)
                {
                    //Ищет все файлы с текстом игнорируя исключения, но и выполняется дольше
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(name))
                        {
                            if (streamReader.ReadToEnd().Equals(textInFile))
                            {
                                stringsPath.Add(name);
                            }
                        }
                    }
                    catch { }
                }
            }
            foreach (string directory in Directory.GetDirectories(dir, "*", options))
            {
                string temp = FindFile(format, directory, textInFile, stringsPath);
                if (temp != "NULL")
                {
                    return temp;
                }
            }
            return "NULL";
        }
    }
}
