using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    public class CSVReader : IEnumerable<Dictionary<string,string>>
    {

        // Open CSV 
        // Read lines
        // Create Accounts(if needed)
        // Validate Transaction data
        // Create Transaction
        // Send transactions
        private string _path;

        public CSVReader(string path)
        {
            _path = path;
        }

        public IEnumerator<Dictionary<string, string>> GetEnumerator()
        {
            using (TextFieldParser textFieldParser = new TextFieldParser(_path))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");
                while (!textFieldParser.EndOfData)
                {
                    // we have to make the IEnumerator, then return it.
                    string[] row = textFieldParser.ReadFields();

                    Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
                    
                }
            }

            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}