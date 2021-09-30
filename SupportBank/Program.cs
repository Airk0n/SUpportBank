using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextFieldParser textFieldParser = new TextFieldParser(@".\Transactions2014.csv"))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");
                while (!textFieldParser.EndOfData)
                {
                    string[] rows = textFieldParser.ReadFields();

                    Console.WriteLine(rows[0] + " " + rows[1] + " " + rows[2] + " " + rows[3] + " " + rows[4]);
                }
            }
        }
    }
}