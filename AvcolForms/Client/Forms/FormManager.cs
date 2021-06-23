using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvcolForms.Pages;

namespace AvcolForms.Forms
{
    class FormManager
    {

        internal static ICollection<Type> _StudentForms = new List<Type>()
        {
            // Add type references to student forms here.
        };

        internal static ICollection<Type> _TeacherForms = new List<Type>()
        {
            // Add type references to teacher forms here.
            typeof(PrinterRequestForm)
        };

        public static List<Type> GetUserForms(FormBrowser.AccountType usertype)
        {

            List<Type> form_list = new List<Type>();
            System.Type[] userForms = { };

            if (usertype == FormBrowser.AccountType.Student)
            {
                userForms = _StudentForms.ToArray();
            }
            if (usertype == FormBrowser.AccountType.Teacher)
            {
                userForms = _TeacherForms.ToArray();
            }
            
            // Add all valid forms to list
            form_list.AddRange(userForms.Where(form_t => form_t.IsSubclassOf(typeof(Form))));

            return form_list;
        }
    }
}
