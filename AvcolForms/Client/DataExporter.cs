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

        public static MemoryStream ExportToTxtFile(FormData data)
        {

            /* Writes all form entries to a text file for easy reference.
             * The file should provide everything listed in the HTML table, in a more offline-accessible format.
             * This may change in future.
            */

            var formData = data.FormattedData;
            string total = "";

            // Heading + title
            total += data.Name;
            total += "\nRecorded " + formData.Count() + " values for user " + "ac000000";
            total += "\n---------------------------------------\n";

            // Form data
            for (int i = 0; i < formData.Count(); i++)
            {
                total += "\n";
                total += formData.Keys.ToArray()[i] + ": ";
                total += formData.Values.ToArray()[i];
            }

            // Write bytes to memory stream
            MemoryStream output = new MemoryStream(Encoding.UTF8.GetBytes(total));
            return output;

        }
    }
}
