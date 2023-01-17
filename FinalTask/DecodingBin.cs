using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FinalTask
{
	public class DecodingBin
	{
        public static void Decoding(string filePath, string CreatePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    List<Student> g150 = new List<Student>();
                    List<Student> g151 = new List<Student>();
                    List<Student> g152 = new List<Student>();
                    List<Student> g153 = new List<Student>();

                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Student[] students = (Student[])formatter.Deserialize(fs);

                        foreach (var student in students)
                        {
                            if (student.Group == "G-150")
                                g150.Add(student);
                            if(student.Group == "G-151")
                                g151.Add(student);
                            if (student.Group == "G-152")
                                g152.Add(student);
                            if (student.Group == "G-153")
                                g153.Add(student);
                        }
                    }

                    WriteFile(CreatePath + "G-150", g150);
                    WriteFile(CreatePath + "G-151", g151);
                    WriteFile(CreatePath + "G-152", g152);
                    WriteFile(CreatePath + "G-153", g153);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
                Console.WriteLine("No");
        }

        public static void WriteFile(string CreatePath, List<Student> groupNumber)
        {
            
            if(!File.Exists(CreatePath))
            {
                using(StreamWriter sw = File.CreateText(CreatePath))
                {
                    foreach (var student in groupNumber)
                    {
                        sw.WriteLine($"{student.Name} {student.DateOfBirth}");
                    }
                }
            }
        }
	}
}

