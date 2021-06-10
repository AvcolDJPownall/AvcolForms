using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AvcolForms.Client
{
    public class EmailFactory
    {

        private static string GetHTMLStyle()
        {
            return "<style>\r\ntable, th, td {\r\n  border: 1px solid black;\r\n  border-collapse: collapse;\r\n}\r\nth, td {\r\n  padding: 4px;\r\n  text-align: left;    \r\n}\r\n</style>";
        }
        public static void SendToDepartment(string address, FormData form, MemoryStream attachment) // Temporary function for testing purposes
        {
            string[] dep_array = { address };
            SendToDepartments(dep_array, form, attachment);
        }
        public static void SendToDepartments(string[] addresses, FormData form, MemoryStream attachment)
        {

            // User credentials
            string from_address = "";
            string authpassword = Encoding.UTF8.GetString(Convert.FromBase64String("")); // This obviously won't be defined in plain text, .NET is far too easy to decompile

            // Define SMTP Server parameters
            // These are placeholders, currently waiting on approval from the IT department
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(from_address, authpassword);

            // Construct message
            MailMessage message = new MailMessage();
            foreach (string to_usr in addresses) message.To.Add(to_usr);
            message.From = new MailAddress(from_address);
            message.Subject = "Form Submission - " + form.Name;


            // Image attachments, might want to give it its own method sometime later
            Assembly assembly = Assembly.GetExecutingAssembly();
            Attachment headimage = new Attachment(assembly.GetManifestResourceStream("AvcolForms.Resources.avcolforms_logo.png"), "headimg.png");
            headimage.ContentId = "logohead";
            message.Attachments.Add(headimage);

            // HTML Formatting
            message.IsBodyHtml = true;
            message.Body = GetHTMLStyle();
            message.Body += "<img width=\"128\" height=\"128\" src=\"cid:logohead\"/><h1>Avcol Forms</h1>\n<p>A user has submitted a digital copy of the '" + form.Name + "' Form. Please see the attachment for their submission.</p>\n\n";
            message.Body += DataExporter.GenerateHTMLTable(form);

            // Attach text file
            string filename = form.Name + from_address.Replace("@avcol.school.nz", "_") + ".txt";
            message.Attachments.Add(new Attachment(attachment, filename));

            smtpClient.Send(message);
            attachment.Close();
        }
    }
}
