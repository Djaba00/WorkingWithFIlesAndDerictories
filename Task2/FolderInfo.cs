using System;
using System.IO;

namespace Task2
{
	public class FolderInfo
	{
		public static long Info(string folderPath)
		{
			long dirSize = 0;
			if (Directory.Exists(folderPath))
			{
				DirectoryInfo dirInfo = new DirectoryInfo(folderPath);

				try
				{
					foreach(FileInfo file in dirInfo.GetFiles())
					{
						dirSize += file.Length;
					}
					foreach(DirectoryInfo dir in dirInfo.GetDirectories())
					{
						foreach(FileInfo file in dir.GetFiles())
						{
							dirSize += file.Length;
						}
					}
					Console.WriteLine($"{dirInfo.Name} size:{dirSize}");
					return dirSize;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
					return dirSize;
				}
			}
			else
			{
                Console.WriteLine("Directory is not found!");
				return dirSize;
            }
        }
	}
}

