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

namespace AvcolForms.Pages
{
    public partial class InnovationAcademyForm : Form
    {
        private FormData FormData;
        public List<string> RequiredKeys = new List<string>();
        public InnovationAcademyForm()
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
            FormData.ModifyAttribute("Staff Code", tb_homeroom.Text);
        }

        private void tb_department_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Department", tb_lname.Text);
        }

        private void chargeToPer_CheckedChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Charge to", radio_yr_9.Checked ? "Personal balance" : "Department");
        }

        private void chargeToDep_CheckedChanged(object sender, EventArgs e)
        {
            // Show additional entries if charging to a department
            FormData.ModifyAttribute("Charge to", radio_yr_10.Checked ? "Department" : "Personal balance");
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
