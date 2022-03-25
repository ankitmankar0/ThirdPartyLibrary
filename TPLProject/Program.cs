using System;

namespace TPLProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read data from csv $ write in csv");
            CsvHandler.ImplementCSVDataHandling();
            Console.WriteLine();
        }
    }
}
