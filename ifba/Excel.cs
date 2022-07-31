using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Excel
    {
        public static void LerExcel()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open("C:\\temp\\Books.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read()) //Each ROW
                        {
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                //Console.WriteLine(reader.GetString(column));//Will blow up if the value is decimal etc. 
                                Console.WriteLine(reader.GetValue(column));//Get Value returns object
                                if ((reader.GetValue(column)) != null)
                                {
                                    using (var client = new WebClient())
                                    {
                                        client.DownloadFile(reader.GetValue(column).ToString(), "C:\\temp\\teste.pdf");
                                    }
                                }
                            }
                        }
                    } while (reader.NextResult()); //Move to NEXT SHEET

                }
            }
        }

    }
}
