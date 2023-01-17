using System;

namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            const string folderPath = @"/Users/frankcowperwood/Development/HW_Module8/Task3/testFolderTask3";

            Console.WriteLine("Task 3\n");

            CleanAndInfo.CandI(folderPath);

            Console.WriteLine("______________________");
        }
    }
}