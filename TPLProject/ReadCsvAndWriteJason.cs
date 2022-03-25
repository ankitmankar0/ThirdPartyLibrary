using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace TPLProject
{
    public class ReadCsvAndWriteJason
    {
        public static void ImplementCSVToJson()
        {
            string importFilePath = @"C:\Users\ankit\Desktop\bridgelab\.Net\Workshop\TPLProject\TPLProject\Utility\addresses.csv";
            string exportFilePath = @"C:\Users\ankit\Desktop\bridgelab\.Net\Workshop\TPLProject\TPLProject\Utility\export.json";

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
                Console.WriteLine("\n******** Now reading from csv and write into Jsonfile ");

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw= new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, record);
                }
            }
        }
    }
}
