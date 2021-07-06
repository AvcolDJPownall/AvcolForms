
namespace AvcolForms.Pages
{
    partial class FormBrowser
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Avaliable Forms");
            this.form_treelist = new System.Windows.Forms.TreeView();
            this.btn_back = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.tb_accountprefix = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form_treelist
            // 
            this.form_treelist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_treelist.FullRowSelect = true;
            this.form_treelist.HotTracking = true;
            this.form_treelist.Indent = 15;
            this.form_treelist.ItemHeight = 20;
            this.form_treelist.Location = new System.Drawing.Point(78, 123);
            this.form_treelist.Name = "form_treelist";
            treeNode9.Name = "ph_text";
            treeNode9.Text = "Avaliable Forms";
            this.form_treelist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.form_treelist.ShowRootLines = false;
            this.form_treelist.Size = new System.Drawing.Size(409, 249);
            this.form_treelist.TabIndex = 0;
            this.form_treelist.DoubleClick += new System.EventHandler(this.OnSelectNodeEvent);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(713, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(70, 53);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(251, 46);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Form Browser";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_accountprefix
            // 
            this.tb_accountprefix.Location = new System.Drawing.Point(520, 207);
            this.tb_accountprefix.MaxLength = 8;
            this.tb_accountprefix.Name = "tb_accountprefix";
            this.tb_accountprefix.Size = new System.Drawing.Size(123, 20);
            this.tb_accountprefix.TabIndex = 3;
            this.tb_accountprefix.TextChanged += new System.EventHandler(this.tb_accountprefix_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_email.Location = new System.Drawing.Point(516, 183);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(99, 21);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email Prefix";
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tb_accountprefix);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.form_treelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormBrowser";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Avcol Forms - Browser";
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView form_treelist;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox tb_accountprefix;
        private System.Windows.Forms.Label label_email;
    }
}