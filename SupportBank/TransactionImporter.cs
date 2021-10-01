using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    public static class TransactionImporter
    {
        public static IEnumerable<Dictionary<string, string>> Read(string path)
        {
            using (TextFieldParser textFieldParser = new TextFieldParser(path))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");
                while (!textFieldParser.EndOfData)
                {
                    string[] row = textFieldParser.ReadFields();
                    
                    // Add data validation
                    
                    Dictionary<string, string> transaction = new Dictionary<string, string>
                    {
                        { "Date", row[0] },
                        { "Sender", row[1] },
                        { "Receiver", row[2] },
                        { "Reference", row[3] },
                        { "Amount", row[4] },
                    };

                    yield return transaction;
                    
                }
            }
        }
    }
}