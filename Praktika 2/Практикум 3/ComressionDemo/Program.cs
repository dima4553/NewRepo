using System;
using System.IO;
using System.IO.Compression;

namespace ComressionDemo
{
    class Program
    {
        //static void CompressFile(string inFileName, string outFileName)
        //{
        //}

        //static void UncompressFile(string inFileName, string outFileName)
        //{
        //}

        static void Main(string[] args)
        {
            string inFileName = @"C:\Users\laik1\source\repos\dima4553\NewRepo\Praktika 2\Практикум 3\123.txt";
            string outFileName = @"C:\Users\laik1\source\repos\dima4553\NewRepo\Praktika 2\Практикум 3\123.txt.gz";

            string inFileName1 = @"C:\Users\laik1\source\repos\dima4553\NewRepo\Praktika 2\Практикум 3\1234.txt";
            FileStream sourceFile = File.OpenRead(outFileName);
            FileStream destFile = File.Create(inFileName1);
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }
            compStream.Close();
        }
    }
}
