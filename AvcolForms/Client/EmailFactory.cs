using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace AvcolForms.Client
{
    public class EmailFactory
    {

        public static void SendToDepartment(string address, Form form, byte[] attachment) // Temporary function for testing purposes
        {
            string[] dep_array = { address };
            SendToDepartments(dep_array, form, attachment);
        }
        public static void SendToDepartments(string[] addresses, Form form, byte[] attachment)
        {

            // User credentials
            string from_address = "";
            string authpassword = ""; // This obviously won't be defined in plain text, .NET is far too easy to decompile

            // Define SMTP Server parameters
            // These are placeholders, currently waiting on approval from the IT department
            SmtpClient smtpClient = new SmtpClient("smtp.avcol.school.nz", 123);
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(from_address, authpassword);

            // Construct message
            MailMessage message = new MailMessage();
            foreach (string to_usr in addresses) message.To.Add(to_usr);
            message.From = new MailAddress(from_address);
            message.Subject = "Form Submission - " + form.Name;
            message.Body = "A member has submitted a digital copy of the '" + form.Name + "' Form. Please see the attachment for their submission";

            MemoryStream fstream = new MemoryStream(attachment);
            string filename = from_address.Replace("@avcol.school.nz", "") + "_" + form.Name + ".txt"; // Use dynamic form names, file extension may change later
            message.Attachments.Add(new Attachment(fstream, filename));

            smtpClient.Send(message);
        }
    }
}
