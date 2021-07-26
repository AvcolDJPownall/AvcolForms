
namespace AvcolForms.Pages
{
    partial class InnovationAcademyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InnovationAcademyForm));
            this.label_title = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_firstname = new System.Windows.Forms.Label();
            this.tb_homeroom = new System.Windows.Forms.TextBox();
            this.label_homeroom = new System.Windows.Forms.Label();
            this.radio_yr_9 = new System.Windows.Forms.RadioButton();
            this.radio_yr_10 = new System.Windows.Forms.RadioButton();
            this.group_yrlevel = new System.Windows.Forms.GroupBox();
            this.radio_yr_13 = new System.Windows.Forms.RadioButton();
            this.radio_yr_12 = new System.Windows.Forms.RadioButton();
            this.radio_yr_11 = new System.Windows.Forms.RadioButton();
            this.label_surname = new System.Windows.Forms.Label();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label_bday = new System.Windows.Forms.Label();
            this.tb_bday = new System.Windows.Forms.TextBox();
            this.label_infotext = new System.Windows.Forms.Label();
            this.label_reg = new System.Windows.Forms.Label();
            this.label_reason = new System.Windows.Forms.Label();
            this.tb_reason = new System.Windows.Forms.TextBox();
            this.group_yrlevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(199, 46);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(365, 46);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Innovation Academy";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_name
            // 
            this.tb_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.Location = new System.Drawing.Point(158, 293);
            this.tb_name.MaxLength = 64;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(171, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_firstname.Location = new System.Drawing.Point(46, 293);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(93, 21);
            this.label_firstname.TabIndex = 3;
            this.label_firstname.Text = "First Name";
            // 
            // tb_homeroom
            // 
            this.tb_homeroom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_homeroom.Location = new System.Drawing.Point(158, 532);
            this.tb_homeroom.MaxLength = 5;
            this.tb_homeroom.Name = "tb_homeroom";
            this.tb_homeroom.Size = new System.Drawing.Size(71, 20);
            this.tb_homeroom.TabIndex = 6;
            this.tb_homeroom.TextChanged += new System.EventHandler(this.homeroom_TextChanged);
            // 
            // label_homeroom
            // 
            this.label_homeroom.AutoSize = true;
            this.label_homeroom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homeroom.Location = new System.Drawing.Point(45, 532);
            this.label_homeroom.Name = "label_homeroom";
            this.label_homeroom.Size = new System.Drawing.Size(106, 21);
            this.label_homeroom.TabIndex = 5;
            this.label_homeroom.Text = "Home Room";
            // 
            // radio_yr_9
            // 
            this.radio_yr_9.AutoSize = true;
            this.radio_yr_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_yr_9.Location = new System.Drawing.Point(6, 30);
            this.radio_yr_9.Name = "radio_yr_9";
            this.radio_yr_9.Size = new System.Drawing.Size(56, 17);
            this.radio_yr_9.TabIndex = 7;
            this.radio_yr_9.TabStop = true;
            this.radio_yr_9.Text = "Year 9";
            this.radio_yr_9.UseVisualStyleBackColor = true;
            this.radio_yr_9.CheckedChanged += new System.EventHandler(this.yearlevel_CheckedChanged);
            // 
            // radio_yr_10
            // 
            this.radio_yr_10.AutoSize = true;
            this.radio_yr_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_yr_10.Location = new System.Drawing.Point(6, 58);
            this.radio_yr_10.Name = "radio_yr_10";
            this.radio_yr_10.Size = new System.Drawing.Size(62, 17);
            this.radio_yr_10.TabIndex = 8;
            this.radio_yr_10.TabStop = true;
            this.radio_yr_10.Text = "Year 10";
            this.radio_yr_10.UseVisualStyleBackColor = true;
            this.radio_yr_10.CheckedChanged += new System.EventHandler(this.yearlevel_CheckedChanged);
            // 
            // group_yrlevel
            // 
            this.group_yrlevel.Controls.Add(this.radio_yr_13);
            this.group_yrlevel.Controls.Add(this.radio_yr_12);
            this.group_yrlevel.Controls.Add(this.radio_yr_11);
            this.group_yrlevel.Controls.Add(this.radio_yr_10);
            this.group_yrlevel.Controls.Add(this.radio_yr_9);
            this.group_yrlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_yrlevel.Location = new System.Drawing.Point(53, 579);
            this.group_yrlevel.Name = "group_yrlevel";
            this.group_yrlevel.Size = new System.Drawing.Size(98, 178);
            this.group_yrlevel.TabIndex = 8;
            this.group_yrlevel.TabStop = false;
            this.group_yrlevel.Text = "Year Level";
            // 
            // radio_yr_13
            // 
            this.radio_yr_13.AutoSize = true;
            this.radio_yr_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_yr_13.Location = new System.Drawing.Point(6, 139);
            this.radio_yr_13.Name = "radio_yr_13";
            this.radio_yr_13.Size = new System.Drawing.Size(62, 17);
            this.radio_yr_13.TabIndex = 11;
            this.radio_yr_13.TabStop = true;
            this.radio_yr_13.Text = "Year 13";
            this.radio_yr_13.UseMnemonic = false;
            this.radio_yr_13.UseVisualStyleBackColor = true;
            this.radio_yr_13.CheckedChanged += new System.EventHandler(this.yearlevel_CheckedChanged);
            // 
            // radio_yr_12
            // 
            this.radio_yr_12.AutoSize = true;
            this.radio_yr_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_yr_12.Location = new System.Drawing.Point(6, 112);
            this.radio_yr_12.Name = "radio_yr_12";
            this.radio_yr_12.Size = new System.Drawing.Size(62, 17);
            this.radio_yr_12.TabIndex = 10;
            this.radio_yr_12.TabStop = true;
            this.radio_yr_12.Text = "Year 12";
            this.radio_yr_12.UseMnemonic = false;
            this.radio_yr_12.UseVisualStyleBackColor = true;
            this.radio_yr_12.CheckedChanged += new System.EventHandler(this.yearlevel_CheckedChanged);
            // 
            // radio_yr_11
            // 
            this.radio_yr_11.AutoSize = true;
            this.radio_yr_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_yr_11.Location = new System.Drawing.Point(6, 86);
            this.radio_yr_11.Name = "radio_yr_11";
            this.radio_yr_11.Size = new System.Drawing.Size(62, 17);
            this.radio_yr_11.TabIndex = 9;
            this.radio_yr_11.TabStop = true;
            this.radio_yr_11.Text = "Year 11";
            this.radio_yr_11.UseMnemonic = false;
            this.radio_yr_11.UseVisualStyleBackColor = true;
            this.radio_yr_11.CheckedChanged += new System.EventHandler(this.yearlevel_CheckedChanged);
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_surname.Location = new System.Drawing.Point(45, 342);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(78, 21);
            this.label_surname.TabIndex = 11;
            this.label_surname.Text = "Surname";
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(158, 342);
            this.tb_lname.MaxLength = 64;
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(171, 20);
            this.tb_lname.TabIndex = 2;
            this.tb_lname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(357, 1009);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 13;
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
            this.error_text.Location = new System.Drawing.Point(474, 1009);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 20);
            this.error_text.TabIndex = 13;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_email.Location = new System.Drawing.Point(46, 393);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 21);
            this.label_email.TabIndex = 15;
            this.label_email.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_email.Location = new System.Drawing.Point(158, 393);
            this.tb_email.MaxLength = 64;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(171, 20);
            this.tb_email.TabIndex = 3;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_phone.Location = new System.Drawing.Point(46, 436);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(59, 21);
            this.label_phone.TabIndex = 17;
            this.label_phone.Text = "Phone";
            // 
            // tb_phone
            // 
            this.tb_phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_phone.Location = new System.Drawing.Point(158, 439);
            this.tb_phone.MaxLength = 16;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(171, 20);
            this.tb_phone.TabIndex = 4;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // label_bday
            // 
            this.label_bday.AutoSize = true;
            this.label_bday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_bday.Location = new System.Drawing.Point(46, 484);
            this.label_bday.Name = "label_bday";
            this.label_bday.Size = new System.Drawing.Size(73, 21);
            this.label_bday.TabIndex = 19;
            this.label_bday.Text = "Birthday";
            // 
            // tb_bday
            // 
            this.tb_bday.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_bday.Location = new System.Drawing.Point(158, 484);
            this.tb_bday.MaxLength = 12;
            this.tb_bday.Name = "tb_bday";
            this.tb_bday.Size = new System.Drawing.Size(93, 20);
            this.tb_bday.TabIndex = 5;
            this.tb_bday.TextChanged += new System.EventHandler(this.tb_bday_TextChanged);
            // 
            // label_infotext
            // 
            this.label_infotext.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infotext.Location = new System.Drawing.Point(49, 168);
            this.label_infotext.Name = "label_infotext";
            this.label_infotext.Size = new System.Drawing.Size(727, 71);
            this.label_infotext.TabIndex = 20;
            this.label_infotext.Text = resources.GetString("label_infotext.Text");
            this.label_infotext.UseCompatibleTextRendering = true;
            // 
            // label_reg
            // 
            this.label_reg.AutoSize = true;
            this.label_reg.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reg.Location = new System.Drawing.Point(44, 131);
            this.label_reg.Name = "label_reg";
            this.label_reg.Size = new System.Drawing.Size(95, 28);
            this.label_reg.TabIndex = 21;
            this.label_reg.Text = "Register";
            this.label_reg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_reason
            // 
            this.label_reason.AutoSize = true;
            this.label_reason.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reason.Location = new System.Drawing.Point(45, 801);
            this.label_reason.Name = "label_reason";
            this.label_reason.Size = new System.Drawing.Size(396, 21);
            this.label_reason.TabIndex = 23;
            this.label_reason.Text = "Provide a brief outline of your reason for applying:";
            // 
            // tb_reason
            // 
            this.tb_reason.Location = new System.Drawing.Point(49, 838);
            this.tb_reason.Multiline = true;
            this.tb_reason.Name = "tb_reason";
            this.tb_reason.Size = new System.Drawing.Size(694, 149);
            this.tb_reason.TabIndex = 12;
            this.tb_reason.TextChanged += new System.EventHandler(this.tb_reason_TextChanged);
            // 
            // InnovationAcademyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 1114);
            this.Controls.Add(this.tb_reason);
            this.Controls.Add(this.label_reason);
            this.Controls.Add(this.label_reg);
            this.Controls.Add(this.label_infotext);
            this.Controls.Add(this.label_bday);
            this.Controls.Add(this.tb_bday);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.group_yrlevel);
            this.Controls.Add(this.label_homeroom);
            this.Controls.Add(this.tb_homeroom);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_title);
            this.Name = "InnovationAcademyForm";
            this.group_yrlevel.ResumeLayout(false);
            this.group_yrlevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TextBox tb_homeroom;
        private System.Windows.Forms.Label label_homeroom;
        private System.Windows.Forms.RadioButton radio_yr_10;
        private System.Windows.Forms.GroupBox group_yrlevel;
        private System.Windows.Forms.RadioButton radio_yr_9;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label error_text;
        private System.Windows.Forms.RadioButton radio_yr_11;
        private System.Windows.Forms.RadioButton radio_yr_12;
        private System.Windows.Forms.RadioButton radio_yr_13;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label_bday;
        private System.Windows.Forms.TextBox tb_bday;
        private System.Windows.Forms.Label label_infotext;
        private System.Windows.Forms.Label label_reg;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.TextBox tb_reason;
    }
}

