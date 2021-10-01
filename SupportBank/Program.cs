using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read CSV. (part 1)
            // Create accounts/check they exist (part 2)
            // Create Transactions (part 2)
            // Generate (part 3)
            
            //(part 4 after push)
            
            // test
            foreach (var csvRow in CsvReader.Read(@"./Transactions2014.csv"))
            {
                Console.WriteLine(csvRow);
            }


        }
    }
}