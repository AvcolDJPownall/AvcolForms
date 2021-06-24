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

            string[] req_fields = { "First Name", "Last Name", "Email", "Home Room", "Year Level" };
            RequiredKeys.AddRange(req_fields);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("First Name", tb_name.Text);
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Last Name", tb_lname.Text);
        }

        private void homeroom_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Home Room", tb_homeroom.Text);
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Email", tb_email.Text);
        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Phone Number", tb_phone.Text);
        }

        private void tb_bday_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Date of Birth", tb_bday.Text);
        }

        private void tb_reason_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Reason for Applying", tb_reason.Text);
        }

        private void yearlevel_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] radios = { radio_yr_9, radio_yr_10, radio_yr_11, radio_yr_12, radio_yr_13 };
            for (int i = 0; i < radios.Length; i++)
            {
                RadioButton button = radios[i];
                if (button.Checked)
                {
                    FormData.ModifyAttribute("Year Level", (i + 9).ToString());
                }
            }
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
