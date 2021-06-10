using AvcolForms.Client;
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

namespace AvcolForms
{
    public partial class PrinterRequestForm : Form
    {
        private FormData FormData;
        public List<string> RequiredKeys = new List<string>();
        public PrinterRequestForm()
        {
            InitializeComponent();
            FormData = new FormData(this);

            string[] req_fields = { "Name", "Staff Code", "Department", "Charge to" };
            RequiredKeys.AddRange(req_fields);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Name", tb_name.Text);
        }

        private void staffcode_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Staff Code", tb_staffcode.Text);
        }

        private void tb_department_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Department", tb_department.Text);
        }

        private void chargeToPer_CheckedChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Charge to", radio_chargeto_personal.Checked ? "Personal balance" : "Department");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chargeToDep_CheckedChanged(object sender, EventArgs e)
        {
            // Show additional entries if charging to a department
            panel_depcharge.Visible = radio_chargeto_department.Checked;
            FormData.ModifyAttribute("Charge to", radio_chargeto_department.Checked ? "Department" : "Personal balance");
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            // Validate inputs and check all required fields are filled
            var data = FormData.FormattedData;
            if (!RequiredKeys.Any() || RequiredKeys.All(field => data.ContainsKey(field)))
            {
                error_text.Text = "";
                EmailFactory.SendToDepartment("ac107151@avcol.school.nz", FormData, DataExporter.ExportToTxtFile(FormData));
            }
            else
            {
                error_text.Text = "You are missing some required fields.";
            }

        }
    }
}
