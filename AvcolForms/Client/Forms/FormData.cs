using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms.Client
{
    // This object stores basic form entries inside a key/value dictionary.
    // NOTE TO SELF: Try not to introduce memory leaks when the user selects multiple forms.
    // The garbage collector might not realize the object is not in use.
    public class FormData
    {
        public Dictionary<string, string> FormattedData;
        public string Name;
        public string[] Recipients = { };

        public void ModifyAttribute(string key, string value)
        {
            if (!FormattedData.ContainsKey(key))
            {
                FormattedData.Add(key, value);
            }
            else FormattedData[key] = value;
            if (value == "") FormattedData.Remove(key);
        }

        public FormData(Form form, string[] addresses)
        {
            FormattedData = new Dictionary<string, string>();
            this.Recipients = addresses;
            this.Name = form.Name;
        }
    }
}
