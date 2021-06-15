using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms.Pages
{
    public partial class FormBrowser : Form
    {
        public enum AccountType { Student, Teacher };
        public FormBrowser(AccountType type)
        {
            InitializeComponent();
        }
    }
}
