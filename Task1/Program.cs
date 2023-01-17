using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            const string folderPath = @"/Users/frankcowperwood/Development/HW_Module8/HW_Module8/testFolderTask1";

            Console.WriteLine("Task 1\n"); 
            
            DirectoryCleaner.Cleaner(folderPath);

            Console.WriteLine("______________________");

        }
    }
}

