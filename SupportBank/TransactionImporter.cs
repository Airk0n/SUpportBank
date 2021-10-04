using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    public enum SupportedFileTypes
    {
        csv,
        json,
        xml,
        notSupported
    }
    public static class TransactionImporter
    {

        public static IEnumerable<Dictionary<string, string>> Read(string path)
        {
            // determine file type
            switch (isSupportedFileType(path))
            {
                case SupportedFileTypes.csv:
                    TextFieldParser textFieldParser = new TextFieldParser(path);
                    foreach (var tobenamed in CsvToDictionary(textFieldParser))
                    {
                        yield return tobenamed;
                    }
                    // yield return CsvToDictionary(textFieldParser);
                    break;
                case SupportedFileTypes.json:
                    break;
                case SupportedFileTypes.xml:
                    break;
                case SupportedFileTypes.notSupported:
                    break;
            }
        }

        private static SupportedFileTypes isSupportedFileType(string path)
        {
            // extract file extension(shall we use regular expressions?)
            // check if file extension is in the list of supportedFileTypes
            // give the correct enum based on if it's supported.
            return SupportedFileTypes.csv;
        }
        
        private static IEnumerable<Dictionary<string, string>> CsvToDictionary(TextFieldParser textFieldParser)
        {
            using (textFieldParser)
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