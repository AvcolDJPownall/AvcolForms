
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.form_list = new System.Windows.Forms.ListView();
            this.img_avcolformslogo = new System.Windows.Forms.PictureBox();
            this.logo_container = new System.Windows.Forms.Panel();
            this.text_logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_avcolformslogo)).BeginInit();
            this.logo_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_list
            // 
            this.form_list.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_list.HideSelection = false;
            this.form_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.form_list.Location = new System.Drawing.Point(138, 236);
            this.form_list.Name = "form_list";
            this.form_list.Size = new System.Drawing.Size(191, 97);
            this.form_list.TabIndex = 1;
            this.form_list.UseCompatibleStateImageBehavior = false;
            this.form_list.View = System.Windows.Forms.View.SmallIcon;
            this.form_list.SelectedIndexChanged += new System.EventHandler(this.form_list_SelectedIndexChanged);
            // 
            // img_avcolformslogo
            // 
            this.img_avcolformslogo.Image = ((System.Drawing.Image)(resources.GetObject("img_avcolformslogo.Image")));
            this.img_avcolformslogo.Location = new System.Drawing.Point(3, 14);
            this.img_avcolformslogo.Name = "img_avcolformslogo";
            this.img_avcolformslogo.Size = new System.Drawing.Size(146, 124);
            this.img_avcolformslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_avcolformslogo.TabIndex = 2;
            this.img_avcolformslogo.TabStop = false;
            // 
            // logo_container
            // 
            this.logo_container.Controls.Add(this.text_logo);
            this.logo_container.Controls.Add(this.img_avcolformslogo);
            this.logo_container.Location = new System.Drawing.Point(88, 12);
            this.logo_container.Name = "logo_container";
            this.logo_container.Size = new System.Drawing.Size(584, 150);
            this.logo_container.TabIndex = 3;
            // 
            // text_logo
            // 
            this.text_logo.AutoSize = true;
            this.text_logo.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_logo.Location = new System.Drawing.Point(154, 37);
            this.text_logo.Name = "text_logo";
            this.text_logo.Size = new System.Drawing.Size(427, 79);
            this.text_logo.TabIndex = 4;
            this.text_logo.Text = "Avcol Forms";
            this.text_logo.Click += new System.EventHandler(this.text_logo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logo_container);
            this.Controls.Add(this.form_list);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.img_avcolformslogo)).EndInit();
            this.logo_container.ResumeLayout(false);
            this.logo_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView form_list;
        private System.Windows.Forms.PictureBox img_avcolformslogo;
        private System.Windows.Forms.Panel logo_container;
        private System.Windows.Forms.Label text_logo;
    }
}