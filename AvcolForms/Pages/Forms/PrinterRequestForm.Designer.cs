
namespace AvcolForms.Pages
{
    partial class PrinterRequestForm
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
            this.label_title = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tb_staffcode = new System.Windows.Forms.TextBox();
            this.label_staffcode = new System.Windows.Forms.Label();
            this.radio_chargeto_personal = new System.Windows.Forms.RadioButton();
            this.radio_chargeto_department = new System.Windows.Forms.RadioButton();
            this.group_chargeto = new System.Windows.Forms.GroupBox();
            this.panel_depcharge = new System.Windows.Forms.Panel();
            this.label_chargetodepnote = new System.Windows.Forms.Label();
            this.label_department = new System.Windows.Forms.Label();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.group_chargeto.SuspendLayout();
            this.panel_depcharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(152, 46);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(510, 46);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Print and Copy Request Form";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_name
            // 
            this.tb_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.Location = new System.Drawing.Point(129, 142);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(88, 145);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name";
            // 
            // tb_staffcode
            // 
            this.tb_staffcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_staffcode.Location = new System.Drawing.Point(374, 142);
            this.tb_staffcode.Name = "tb_staffcode";
            this.tb_staffcode.Size = new System.Drawing.Size(100, 20);
            this.tb_staffcode.TabIndex = 4;
            this.tb_staffcode.TextChanged += new System.EventHandler(this.staffcode_TextChanged);
            // 
            // label_staffcode
            // 
            this.label_staffcode.AutoSize = true;
            this.label_staffcode.Location = new System.Drawing.Point(311, 146);
            this.label_staffcode.Name = "label_staffcode";
            this.label_staffcode.Size = new System.Drawing.Size(57, 13);
            this.label_staffcode.TabIndex = 5;
            this.label_staffcode.Text = "Staff Code";
            // 
            // radio_chargeto_personal
            // 
            this.radio_chargeto_personal.AutoSize = true;
            this.radio_chargeto_personal.Location = new System.Drawing.Point(6, 19);
            this.radio_chargeto_personal.Name = "radio_chargeto_personal";
            this.radio_chargeto_personal.Size = new System.Drawing.Size(150, 17);
            this.radio_chargeto_personal.TabIndex = 6;
            this.radio_chargeto_personal.TabStop = true;
            this.radio_chargeto_personal.Text = "Charge to personal budget";
            this.radio_chargeto_personal.UseVisualStyleBackColor = true;
            this.radio_chargeto_personal.CheckedChanged += new System.EventHandler(this.chargeToPer_CheckedChanged);
            // 
            // radio_chargeto_department
            // 
            this.radio_chargeto_department.AutoSize = true;
            this.radio_chargeto_department.Location = new System.Drawing.Point(6, 42);
            this.radio_chargeto_department.Name = "radio_chargeto_department";
            this.radio_chargeto_department.Size = new System.Drawing.Size(127, 17);
            this.radio_chargeto_department.TabIndex = 7;
            this.radio_chargeto_department.TabStop = true;
            this.radio_chargeto_department.Text = "Charge to department";
            this.radio_chargeto_department.UseVisualStyleBackColor = true;
            this.radio_chargeto_department.CheckedChanged += new System.EventHandler(this.chargeToDep_CheckedChanged);
            // 
            // group_chargeto
            // 
            this.group_chargeto.Controls.Add(this.radio_chargeto_department);
            this.group_chargeto.Controls.Add(this.radio_chargeto_personal);
            this.group_chargeto.Location = new System.Drawing.Point(91, 206);
            this.group_chargeto.Name = "group_chargeto";
            this.group_chargeto.Size = new System.Drawing.Size(200, 100);
            this.group_chargeto.TabIndex = 8;
            this.group_chargeto.TabStop = false;
            this.group_chargeto.Text = "Charge to...";
            // 
            // panel_depcharge
            // 
            this.panel_depcharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_depcharge.Controls.Add(this.label_chargetodepnote);
            this.panel_depcharge.Location = new System.Drawing.Point(307, 206);
            this.panel_depcharge.Name = "panel_depcharge";
            this.panel_depcharge.Size = new System.Drawing.Size(472, 100);
            this.panel_depcharge.TabIndex = 9;
            this.panel_depcharge.Visible = false;
            // 
            // label_chargetodepnote
            // 
            this.label_chargetodepnote.AutoSize = true;
            this.label_chargetodepnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chargetodepnote.Location = new System.Drawing.Point(4, 4);
            this.label_chargetodepnote.Name = "label_chargetodepnote";
            this.label_chargetodepnote.Size = new System.Drawing.Size(452, 13);
            this.label_chargetodepnote.TabIndex = 0;
            this.label_chargetodepnote.Text = "NOTE: If you also have a restricted print/copy budget, complete the following:";
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Location = new System.Drawing.Point(527, 146);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(62, 13);
            this.label_department.TabIndex = 11;
            this.label_department.Text = "Department";
            // 
            // tb_department
            // 
            this.tb_department.Location = new System.Drawing.Point(595, 142);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(100, 20);
            this.tb_department.TabIndex = 10;
            this.tb_department.TextChanged += new System.EventHandler(this.tb_department_TextChanged);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(357, 715);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 12;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.BackColor = System.Drawing.SystemColors.Control;
            this.error_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.error_text.Location = new System.Drawing.Point(474, 715);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 20);
            this.error_text.TabIndex = 13;
            // 
            // PrinterRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_department);
            this.Controls.Add(this.tb_department);
            this.Controls.Add(this.panel_depcharge);
            this.Controls.Add(this.group_chargeto);
            this.Controls.Add(this.label_staffcode);
            this.Controls.Add(this.tb_staffcode);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_title);
            this.Name = "PrinterRequestForm";
            this.TopMost = true;
            this.group_chargeto.ResumeLayout(false);
            this.group_chargeto.PerformLayout();
            this.panel_depcharge.ResumeLayout(false);
            this.panel_depcharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox tb_staffcode;
        private System.Windows.Forms.Label label_staffcode;
        private System.Windows.Forms.RadioButton radio_chargeto_department;
        private System.Windows.Forms.GroupBox group_chargeto;
        private System.Windows.Forms.Panel panel_depcharge;
        private System.Windows.Forms.Label label_chargetodepnote;
        private System.Windows.Forms.RadioButton radio_chargeto_personal;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label error_text;
    }
}

