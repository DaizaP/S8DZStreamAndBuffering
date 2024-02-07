namespace S8DZStreamAndBuffering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программа игнорирует директории к которым нет доступа
            //TaskDZ.TaskHomerork(".txt", "Yes, you find me");
            TaskDZ.TaskHomerork(args[0], args[1]);
        }
    }
}
