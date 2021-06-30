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
    public partial class PropertyServiceRequest : Form
    {
        private FormData FormData;
        public List<string> RequiredKeys = new List<string>();
        public PropertyServiceRequest()
        {
            InitializeComponent();

            string[] req_fields = { "Name", "Email", "Phone Number", "Topic", "Summary", "Details" }; // Fields that must be filled before submitting.
            string[] recipients = { "ac107151@avcol.school.nz" }; // List of addresses to carbon-copy to.
            FormData = new FormData(this, recipients);

            RequiredKeys.AddRange(req_fields);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Name", tb_name.Text);
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Email", tb_email.Text);
        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Phone Number", tb_phone.Text);
        }

        private void tb_subject_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Summary", tb_reason.Text);
        }

        private void tb_reason_TextChanged(object sender, EventArgs e)
        {
            FormData.ModifyAttribute("Details", tb_reason.Text);
        }

        private void topic_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] radios = { radio_topic_feedback, radio_topic_general, radio_topic_safety, radio_topic_problem };
            for (int i = 0; i < radios.Length; i++)
            {
                RadioButton button = radios[i];
                if (button.Checked)
                {
                    FormData.ModifyAttribute("Topic", button.Text);
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
                EmailFactory.SendToDepartments(FormData, DataExporter.ExportToTxtFile(FormData));
            }
            else
            {
                error_text.Text = "You are missing some required fields.";
            }

        }
    }
}
