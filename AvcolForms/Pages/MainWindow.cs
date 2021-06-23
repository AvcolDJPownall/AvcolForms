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
        
        // All elements are private, so we use a public method.
        public void SetHomeVisibility(bool isVisible) 
        {
            panel_initalscreen.Visible = isVisible;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Form browser = new FormBrowser(FormBrowser.AccountType.Student);
            browser.MdiParent = this;
            panel_initalscreen.Visible = false;
            browser.Show();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            Form browser = new FormBrowser(FormBrowser.AccountType.Teacher);
            browser.MdiParent = this;
            panel_initalscreen.Visible = false;
            browser.Show();
        }
    }
}
