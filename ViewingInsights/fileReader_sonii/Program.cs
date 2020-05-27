using System;
using System.IO;

namespace fileReader_sonii
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader x;
            Console.WriteLine("Hello World!"); 
            string path= @"C:\Users\Sonica Samgi\Documents\teste.txt";

            x = File.OpenText(path);
            string linha = x.ReadLine();
            Console.WriteLine(linha);
            Console.WriteLine("o nuno é estupido");

        }
    }
}
