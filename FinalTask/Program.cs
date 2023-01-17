using System;

namespace FinalTask
{
    public class Program
    {
        public static void Main()
        {
            string filePath = @"/Users/frankcowperwood/Desktop/Students.dat";
            string CreatePath = @"/Users/frankcowperwood/Desktop/Students/";
            DecodingBin.Decoding(filePath, CreatePath);
            Console.ReadKey();
        }
    }
}
