using AvcolForms.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms.Client
{
    public class EmailFactory
    {

        private static string GetHTMLStyle()
        {
            return "<style>\r\ntable, th, td {\r\n  border: 1px solid black;\r\n  border-collapse: collapse;\r\n}\r\nth, td {\r\n  padding: 4px;\r\n  text-align: left;    \r\n}\r\n</style>";
        }
        public static void SendToDepartments(FormData form, MemoryStream attachment)
        {
            bool hasError = false;
            LoadingWindow loadingBar = new LoadingWindow();
            try
            {
                string from_address = "avondaleforms@gmail.com";
                string authpassword = Encoding.UTF8.GetString(Convert.FromBase64String("QXZjb2xGb3JtczEyMw==")); // This obviously won't be defined in plain text, .NET is far too easy to decompile

                // Define SMTP Server parameters
                // These are placeholders, currently waiting on approval from the IT department
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(from_address, authpassword);

                // Construct message
                MailMessage message = new MailMessage();
                foreach (string to_usr in form.Recipients) message.To.Add(to_usr);
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

                Task.Run(() => loadingBar.ShowDialog());
                smtpClient.Send(message);
                
            }
            catch (Exception error)
            {
                string message = error.Message; // Default 'generic' error text
                if (error is SmtpException) message = "Unable to connect to the mail server. Check that you are connected to the internet.";
                if (error is SmtpFailedRecipientException) message = "One or more recipients failed to receive the form data.";

                hasError = true;

                loadingBar.ShowMessage("An error occured sending your submission:\n" + message, true);
            }
            finally
            {
                if (!hasError) loadingBar.ShowMessage("Upload complete.", false);
                Application.Restart();
            }
        }
    }
}
