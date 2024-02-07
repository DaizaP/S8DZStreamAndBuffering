namespace S8DZStreamAndBuffering
{
    class Task3
    {
        public static void TaskThree()
        {
            string path = @"C:\Games";

            string fileName = "findme.txt";

            string filePath = FindFile(fileName, path);
            if (Path.Exists(filePath))
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {

                }
            }
        }

        static string FindFile(string fileName, string dir)
        {
            foreach (string name in Directory.GetFiles(dir))
            {
                if (Path.GetFileName(name) == fileName)
                {
                        return name;
                }
            }
            foreach (string directory in Directory.GetDirectories(dir))
            {
                string temp = FindFile(fileName, directory);
                if (temp != "NULL")
                {
                    return temp;
                }
            }
            return "NULL";
        }
    }
}
