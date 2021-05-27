using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms.Client
{
    // At the moment, I'm temporarily storing generic form data in these objects.
    // This will eventually be written to a file as an email attachment.
    public class FormData
    {
        public Dictionary<string, string> FormattedData;
        public string Name;

        public void ModifyAttribute(string key, string value)
        {
            if (!FormattedData.ContainsKey(key))
            {
                FormattedData.Add(key, value);
            }
            else FormattedData[key] = value;
        }

        public FormData(Form form)
        {
            FormattedData = new Dictionary<string, string>();
            this.Name = form.Name;
        }
    }
}
