
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Select a form");
            this.form_treelist = new System.Windows.Forms.TreeView();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form_treelist
            // 
            this.form_treelist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_treelist.Indent = 15;
            this.form_treelist.ItemHeight = 20;
            this.form_treelist.Location = new System.Drawing.Point(107, 137);
            this.form_treelist.Name = "form_treelist";
            treeNode3.Name = "ph_text";
            treeNode3.Text = "Select a form";
            this.form_treelist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.form_treelist.Size = new System.Drawing.Size(409, 249);
            this.form_treelist.TabIndex = 0;
            this.form_treelist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.form_treelist_AfterSelect);
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
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.form_treelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBrowser";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Avcol Forms - Browser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView form_treelist;
        private System.Windows.Forms.Button btn_back;
    }
}