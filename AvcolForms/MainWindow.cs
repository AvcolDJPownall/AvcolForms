using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvcolForms.Pages;

namespace AvcolForms
{
    public partial class MainWindow : Form
    {

        private List<Type> AvaliableForms = new List<Type>()
        {
            typeof(PrinterRequestForm)
        };

        public MainWindow()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Image logoimg = img_avcolformslogo.Image;
            Assembly assembly = Assembly.GetExecutingAssembly();
            logoimg = Image.FromStream(assembly.GetManifestResourceStream("AvcolForms.Resources.avcolforms_logo.png"));

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = e.Node.Index;
            //Application.Run(AvaliableForms[index]);

        }

        private void form_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text_logo_Click(object sender, EventArgs e)
        {

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Form browser = new FormBrowser(FormBrowser.AccountType.Student);
            browser.MdiParent = this;
            browser.WindowState = FormWindowState.Maximized;
            browser.Show();
            browser.BringToFront();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            Form browser = new FormBrowser(FormBrowser.AccountType.Teacher);
            browser.MdiParent = this;
            browser.WindowState = FormWindowState.Maximized;
            browser.Show();
            this.Hide();
        }
    }
}
