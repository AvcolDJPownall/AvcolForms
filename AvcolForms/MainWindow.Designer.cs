
namespace AvcolForms
{
    partial class MainWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Printer Request Form");
            this.form_list = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // form_list
            // 
            this.form_list.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_list.HideSelection = false;
            this.form_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.form_list.Location = new System.Drawing.Point(155, 89);
            this.form_list.Name = "form_list";
            this.form_list.Size = new System.Drawing.Size(191, 97);
            this.form_list.TabIndex = 1;
            this.form_list.UseCompatibleStateImageBehavior = false;
            this.form_list.View = System.Windows.Forms.View.SmallIcon;
            this.form_list.SelectedIndexChanged += new System.EventHandler(this.form_list_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form_list);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView form_list;
    }
}