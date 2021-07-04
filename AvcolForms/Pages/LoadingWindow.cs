using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms.Pages
{
    public partial class LoadingWindow : Form
    {
        public LoadingWindow()
        {
            InitializeComponent();
            Rectangle screensize = Screen.PrimaryScreen.Bounds;
            this.Location = new Point((screensize.Width / 2) - this.Width, (screensize.Height / 2) - 200);
            this.StartPosition = this.StartPosition = FormStartPosition.Manual;
        }

        public void ShowMessage(string text, bool isError)
        {
            MessageBoxIcon icon =  MessageBoxIcon.Information;
            string title = "Avcol Forms";

            if (isError)
            {
                icon = MessageBoxIcon.Error;
                title = "Error";
            }
            MessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        internal void IncrementBar()
        {
            Random rng = new Random();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(rng.Next(50, 200));
                loadingbar.Value = + 1;
            }
        }
    }
}
