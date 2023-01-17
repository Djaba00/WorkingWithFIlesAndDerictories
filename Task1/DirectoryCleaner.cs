using System;
using System.IO;

namespace Task1
{
    public class DirectoryCleaner
    {
        public static void Cleaner(string folderPath)
        {
            TimeSpan deleteTime = TimeSpan.FromMinutes(0);
            TimeSpan accesTime = new TimeSpan(0);
            int delFiles = 0;

            if (Directory.Exists(folderPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
                try
                {
                    Delete(dirInfo, accesTime, deleteTime, out delFiles);
                    Console.WriteLine($"Cleaning done. Deleted {delFiles} files.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
                Console.WriteLine("Directory is not found!");
        }

        static void Delete(DirectoryInfo dirInfo, TimeSpan accesTime, TimeSpan deleteTime, out int delFiles)
        {
            // удаление файлов
            Console.WriteLine("Deleted files:\n");
            delFiles = 0;
            FileInfo[] filesCount;
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                accesTime = DateTime.Now - file.LastAccessTime;

                if (accesTime > deleteTime)
                {
                    file.Delete();
                    Console.WriteLine(file.Name);
                    delFiles++;
                }
            }

            // удаление папок
            Console.WriteLine("Deleted folders:\n");
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                accesTime = DateTime.Now - dir.LastAccessTime;
                
                if (accesTime > deleteTime)
                {
                    filesCount =  dir.GetFiles();
                    delFiles += filesCount.Length;
                    dir.Delete(true);
                    Console.WriteLine($"{dir.Name} (files in folder {filesCount.Length})");
                }
            }
        }
    }
}

