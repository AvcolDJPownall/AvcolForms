
namespace AvcolForms.Pages
{
    partial class LoadingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadingbar = new System.Windows.Forms.ProgressBar();
            this.text_sending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadingbar
            // 
            this.loadingbar.Location = new System.Drawing.Point(43, 45);
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.Size = new System.Drawing.Size(252, 23);
            this.loadingbar.Step = 1;
            this.loadingbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingbar.TabIndex = 0;
            this.loadingbar.Value = 80;
            // 
            // text_sending
            // 
            this.text_sending.AutoSize = true;
            this.text_sending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.text_sending.Location = new System.Drawing.Point(40, 20);
            this.text_sending.Name = "text_sending";
            this.text_sending.Size = new System.Drawing.Size(169, 15);
            this.text_sending.TabIndex = 1;
            this.text_sending.Text = "Uploading form, please wait...";
            // 
            // LoadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 80);
            this.ControlBox = false;
            this.Controls.Add(this.text_sending);
            this.Controls.Add(this.loadingbar);
            this.Name = "LoadingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sending...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingbar;
        private System.Windows.Forms.Label text_sending;
    }
}