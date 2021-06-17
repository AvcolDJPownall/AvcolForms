using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvcolForms.Forms;

namespace AvcolForms.Pages
{
    public partial class FormBrowser : Form
    {
        public enum AccountType { Student, Teacher };
        private AccountType UserType;
        public FormBrowser(AccountType type)
        {
            InitializeComponent();
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            List<Type> form_tlist = UserType == AccountType.Student ? FormManager.GetStudentForms() : null; // Implement teacher stuff later!
            foreach (var node in form_tlist)
            {
                form_treelist.Nodes.Add(node.Name);
            }

        }

        private void form_treelist_AfterSelect(object sender, TreeViewEventArgs e)
        {


            foreach (Type type in FormManager.GetStudentForms())
            {
                if (type.Name == form_treelist.SelectedNode.Text)
                {
                    Form newform = (Form)Activator.CreateInstance(type);
                    //this.Hide();
                }
                
            }
            this.Focus();
        }

        // NOTE: If we use MDI for the actual forms, we'll need to implement a back button heirarchy to keep track of the pages.
        private void btn_back_Click(object sender, EventArgs e)
        {
            var parent = (MainWindow)this.MdiParent;
            parent.SetHomeVisibility(true);
            this.Close();
        }
    }
}
