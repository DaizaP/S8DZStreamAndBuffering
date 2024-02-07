namespace S8DZStreamAndBuffering
{
    class TaskDZ
    {
        public static void TaskHomerork(string format, string textInFile)
        {
            //Пробегаемся по всем дискам
            string[] pathArr = Environment.GetLogicalDrives();
            foreach (string path in pathArr)
            {
                string res = FindFile(format, path, textInFile);
                if (res != "NULL") { Console.WriteLine(res); }
            }
        }
        static string FindFile(string format, string dir, string textInFile)
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
                    using (StreamReader streamReader = new StreamReader(name))
                    {
                        string str = "Найдено";
                        if (streamReader.ReadToEnd().Equals(textInFile))
                        {
                            return name;
                        }

                    }
                }
            }
            foreach (string directory in Directory.GetDirectories(dir, "*", options))
            {
                string temp = FindFile(format, directory, textInFile);
                if (temp != "NULL")
                {
                    return temp;
                }
            }
            return "NULL";
        }
    }
}
