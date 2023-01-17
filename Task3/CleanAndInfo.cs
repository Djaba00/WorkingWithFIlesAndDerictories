using System;
using System.IO;
using Task1;
using Task2;

namespace Task3
{
	public class CleanAndInfo
	{
		public static void CandI(string folderPath)
		{
			if(Directory.Exists(folderPath))
			{
				DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
				long dirSize1 = 0;
				long dirSize2 = 0;
				long freeSpace = 0;

                dirSize1 = Task2.FolderInfo.Info(folderPath);
				Console.WriteLine($"\n{dirInfo.Name} initial size: {dirSize1}\n");

                Task1.DirectoryCleaner.Cleaner(folderPath);

                dirSize2 = Task2.FolderInfo.Info(folderPath);
                freeSpace = dirSize1 - dirSize2;
                Console.WriteLine($"\nSaved space: {freeSpace}");

                Console.WriteLine($"\n{dirInfo.Name} Final size: {dirSize2}");
            }
			else
			{
                Console.WriteLine("Directory is not found!");
            }
		}
	}
}

