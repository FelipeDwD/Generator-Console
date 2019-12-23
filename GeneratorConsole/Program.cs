using System;
using System.IO;

namespace GeneratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\FelipeN\Desktop\direct\source");
            string directoryInfoCp = @"C:\Users\FelipeN\Desktop\direct\source\";


            Console.WriteLine("Quantas cópias deseja fazer: ");
            int amountFilesToGenerated = int.Parse(Console.ReadLine());

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                for (int i = 0; i < amountFilesToGenerated; i++)
                {
                    File.Copy(file.FullName, $"{directoryInfoCp}CP{i}{file.Name}");
                }
            }

            Console.WriteLine($"{amountFilesToGenerated} cópias feitas em {directoryInfoCp}");
        }
    }
}
