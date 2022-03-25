using System;

namespace TPLProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read data from csv $ write in Json");
            ReadCsvAndWriteJason.ImplementCSVToJson();
            Console.WriteLine();
        }
    }
}
