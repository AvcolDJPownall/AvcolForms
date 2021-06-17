using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms.Forms
{
    class FormManager
    {
        public static List<Type> GetStudentForms()
        {

            List<Type> form_list = new List<Type>();

            // New forms are defined here.
            System.Type[] formList =
            {
                typeof(PrinterRequestForm)
            };
            
            // Add all valid forms
            form_list.AddRange(formList.Where(form_t => form_t.IsSubclassOf(typeof(Form))));

            return form_list;
        }

    }
}
