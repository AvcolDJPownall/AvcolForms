using AvcolForms.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms
{
    public partial class PrinterRequestForm : Form
    {
        private FormData FormData;
        public PrinterRequestForm()
        {
            InitializeComponent();
            FormData = new FormData(this);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Name", tb_name.Text);
        }

        private void staffcode_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Staff Code", tb_staffcode.Text);
        }

        private void chargeToPer_CheckedChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Charge to Personal", radio_chargeto_personal.Checked.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chargeToDep_CheckedChanged(object sender, EventArgs e)
        {
            // Show additional entries if charging to a department
            panel_depcharge.Visible = radio_chargeto_department.Checked;
            FormData.ModifyAttribute("Charge to Department", radio_chargeto_department.Checked.ToString());
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            // Remember to validate inputs before sending form
            if (true)
            {
                //EmailFactory.SendToDepartment();
            }

        }
    }
}
