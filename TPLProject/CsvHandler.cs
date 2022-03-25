using System;
using System.Linq;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace TPLProject
{
    public class CsvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\ankit\Desktop\bridgelab\.Net\Workshop\TPLProject\TPLProject\Utility\addresses.csv";
            string exportFilePath = @"C:\Users\ankit\Desktop\bridgelab\.Net\Workshop\TPLProject\TPLProject\Utility\export.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var record = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach(AddressData addressData in record)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.Address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.Code);
                    Console.Write("\n");
                }
                Console.WriteLine("\n******** Now reading from csv and write into csv file ");

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                { 
                csvExport.WriteRecords(record); 
                }
            }
        }
    }
}
