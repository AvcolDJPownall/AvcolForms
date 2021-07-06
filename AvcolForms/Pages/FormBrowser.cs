using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvcolForms.Client;
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
            if (UserType == AccountType.Student) label_email.Text = "AC Number";
            if (UserType == AccountType.Teacher) label_email.Text = "Staff Code";
        }
        private void OnSelectNodeEvent(object sender, EventArgs e) 
        {
            if (FormData.EmailPrefix == "") return;
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

        private void tb_accountprefix_TextChanged(object sender, EventArgs e)
        {
            string curtxt = tb_accountprefix.Text;
            string newtxt = "";

            switch (UserType)
            {
                case AccountType.Student:
                    {
                        newtxt = "ac";
                        newtxt += new string(curtxt.Where(char.IsDigit).ToArray());
                        tb_accountprefix.Text = newtxt;
                        tb_accountprefix.SelectionStart = newtxt.Length;
                        tb_accountprefix.MaxLength = 8;
                        break;
                    }

                case AccountType.Teacher:

                    newtxt = new string(curtxt.Where(char.IsLetter).ToArray());
                    tb_accountprefix.Text = newtxt;
                    tb_accountprefix.SelectionStart = newtxt.Length;
                    tb_accountprefix.MaxLength = 4;
                    break;
                default:
                    break;
            }
            FormData.EmailPrefix = tb_accountprefix.Text;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var parent = (MainWindow)this.MdiParent;
            parent.SetHomeVisibility(true);
            this.Close();
        }
    }
}
