using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer =
                File.CreateText(
                    @"C:\Users\laik1\source\repos\dima4553\NewRepo\Praktika 2\Практикум 2\FileDemo\newfile.txt");
            writer.WriteLine("This is my file");
            writer.WriteLine("Do you like its format?");
            writer.Close();

            StreamReader reader =
                File.OpenText(@"C:\Users\laik1\source\repos\dima4553\NewRepo\Praktika 2\Практикум 2\FileDemo\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
        }
    }
}
