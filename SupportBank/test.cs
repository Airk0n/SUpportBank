using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    public class CsvReader
    {
        // static void Main()
        // {
        //     // Display powers of 2 up to the exponent of 8:
        //     foreach (int i in Power(2, 8))
        //     {
        //         Console.Write("{0} ", i);
        //     }
        // }

        public static IEnumerable<string> Read(string _path)
        {
            using (TextFieldParser textFieldParser = new TextFieldParser(_path))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");
                while (!textFieldParser.EndOfData)
                {
                    // we have to make the IEnumerator, then return it.
                    string[] row = textFieldParser.ReadFields();

                    yield return row[0];
                    
                }
            }
            // int result = 1;
            //
            // for (int i = 0; i < exponent; i++)
            // {
            //     result = result * number;
            //     yield return result;
            // }
        }
    }
    // Output: 2 4 8 16 32 64 128 256
}