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
        public enum AccountType { Student, Teacher, Other };
        private AccountType UserType;
        public FormBrowser(AccountType type)
        {
            this.UserType = type;
            InitializeComponent();
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            List<Type> form_tlist = FormManager.GetUserForms(UserType);

            TreeNode parentnode = form_treelist.Nodes[0];
            foreach (var node in form_tlist)
            {
                parentnode.Nodes.Add(node.Name);
            }
            parentnode.Expand();
        }
        private void OnSelectNodeEvent(object sender, EventArgs e) 
        {
            foreach (Type type in FormManager.GetUserForms(UserType))
            {
                if (type.Name == form_treelist.SelectedNode.Text)
                {
                    Form newform = (Form)Activator.CreateInstance(type);
                    newform.Show();
                    newform.Focus();
                    return;
                }
            }
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
