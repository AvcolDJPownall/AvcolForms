using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace AvcolForms.Client
{
    class DataExporter
    {

        private static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public static string GenerateHTMLTable(FormData data)
        {
            var formData = data.FormattedData;
            string total = "<table width=60%>";

            // Body Contruction            

            for (int i = 0; i < formData.Count(); i++)
            {
                string txt_key = formData.Keys.ToArray()[i];
                string txt_val = formData.Values.ToArray()[i];
                total += "<tbody><tr>";
                total += "<th><div><b>" + txt_key + ":</b></div></th>"; // Key text
                total += "<td><div><b>" + txt_val + "</b></div></td>"; // Value text
                total += "</tr></tbody>";
            }

            total += "</table>";
            return total;
        }

        public static MemoryStream ExportToExcel(FormData data)
        {

            /* NOTE: Most of this code will likely be reduntant as the results are now displayed in a HTML table.
             * Previously, this encoded the data into an excel document using Office's interop libraries.
             * I'm keeping this functionality for now, perhaps it'll be used sometime in future.
            */

            Application excelApp = new Application();

            //excelApp.Visible = true; // for debugging purposes

            excelApp.Workbooks.Add();
            Workbook workBook = excelApp.ActiveWorkbook;
            Worksheet workSheet = excelApp.ActiveSheet;

            var formData = data.FormattedData;
            workSheet.Name = data.Name;

            // Write column names (keys) to document
            for (int i = 0; i < formData.Count(); i++)
            {
                string col_index = alphabet[i].ToString();
                workSheet.Cells[1, col_index].Value = formData.Keys.ToArray()[i];
                //((Range)workSheet.Columns[i]).AutoFit();
            }


            MemoryStream output = new MemoryStream();
            //workBook.SaveToStream(output);

            //workBook.SaveAs(data.Name + "_FileTest.xlsx");
            output.Flush();
            return null; // results in an exception for now, too lazy to prevent sending emails

        }
    }
}
