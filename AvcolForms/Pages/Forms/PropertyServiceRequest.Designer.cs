
namespace AvcolForms.Pages
{
    partial class PropertyServiceRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyServiceRequest));
            this.label_title = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.radio_topic_feedback = new System.Windows.Forms.RadioButton();
            this.radio_topic_general = new System.Windows.Forms.RadioButton();
            this.group_topic = new System.Windows.Forms.GroupBox();
            this.radio_topic_problem = new System.Windows.Forms.RadioButton();
            this.radio_topic_safety = new System.Windows.Forms.RadioButton();
            this.button_submit = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label_infotext = new System.Windows.Forms.Label();
            this.label_subheading = new System.Windows.Forms.Label();
            this.label_reason = new System.Windows.Forms.Label();
            this.tb_reason = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.label_subject = new System.Windows.Forms.Label();
            this.group_topic.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(251, 45);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(284, 46);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Service Request";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_name
            // 
            this.tb_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.Location = new System.Drawing.Point(158, 284);
            this.tb_name.MaxLength = 64;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(171, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_name.Location = new System.Drawing.Point(46, 284);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(88, 21);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Full Name";
            // 
            // radio_topic_feedback
            // 
            this.radio_topic_feedback.AutoSize = true;
            this.radio_topic_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_topic_feedback.Location = new System.Drawing.Point(6, 27);
            this.radio_topic_feedback.Name = "radio_topic_feedback";
            this.radio_topic_feedback.Size = new System.Drawing.Size(73, 17);
            this.radio_topic_feedback.TabIndex = 4;
            this.radio_topic_feedback.TabStop = true;
            this.radio_topic_feedback.Text = "Feedback";
            this.radio_topic_feedback.UseVisualStyleBackColor = true;
            this.radio_topic_feedback.CheckedChanged += new System.EventHandler(this.topic_CheckedChanged);
            // 
            // radio_topic_general
            // 
            this.radio_topic_general.AutoSize = true;
            this.radio_topic_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_topic_general.Location = new System.Drawing.Point(6, 50);
            this.radio_topic_general.Name = "radio_topic_general";
            this.radio_topic_general.Size = new System.Drawing.Size(96, 17);
            this.radio_topic_general.TabIndex = 4;
            this.radio_topic_general.Text = "General Inquiry";
            this.radio_topic_general.UseVisualStyleBackColor = true;
            this.radio_topic_general.CheckedChanged += new System.EventHandler(this.topic_CheckedChanged);
            // 
            // group_topic
            // 
            this.group_topic.Controls.Add(this.radio_topic_problem);
            this.group_topic.Controls.Add(this.radio_topic_safety);
            this.group_topic.Controls.Add(this.radio_topic_general);
            this.group_topic.Controls.Add(this.radio_topic_feedback);
            this.group_topic.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.group_topic.Location = new System.Drawing.Point(394, 284);
            this.group_topic.Name = "group_topic";
            this.group_topic.Size = new System.Drawing.Size(173, 140);
            this.group_topic.TabIndex = 4;
            this.group_topic.TabStop = false;
            this.group_topic.Text = "Topic";
            // 
            // radio_topic_problem
            // 
            this.radio_topic_problem.AutoSize = true;
            this.radio_topic_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_topic_problem.Location = new System.Drawing.Point(6, 96);
            this.radio_topic_problem.Name = "radio_topic_problem";
            this.radio_topic_problem.Size = new System.Drawing.Size(107, 17);
            this.radio_topic_problem.TabIndex = 4;
            this.radio_topic_problem.Text = "Report a Problem";
            this.radio_topic_problem.UseMnemonic = false;
            this.radio_topic_problem.UseVisualStyleBackColor = true;
            this.radio_topic_problem.CheckedChanged += new System.EventHandler(this.topic_CheckedChanged);
            // 
            // radio_topic_safety
            // 
            this.radio_topic_safety.AutoSize = true;
            this.radio_topic_safety.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radio_topic_safety.Location = new System.Drawing.Point(6, 73);
            this.radio_topic_safety.Name = "radio_topic_safety";
            this.radio_topic_safety.Size = new System.Drawing.Size(110, 17);
            this.radio_topic_safety.TabIndex = 4;
            this.radio_topic_safety.Text = "Health and Safety";
            this.radio_topic_safety.UseMnemonic = false;
            this.radio_topic_safety.UseVisualStyleBackColor = true;
            this.radio_topic_safety.CheckedChanged += new System.EventHandler(this.topic_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(357, 715);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 7;
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
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_email.Location = new System.Drawing.Point(46, 319);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 21);
            this.label_email.TabIndex = 15;
            this.label_email.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_email.Location = new System.Drawing.Point(158, 319);
            this.tb_email.MaxLength = 64;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(171, 20);
            this.tb_email.TabIndex = 2;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_phone.Location = new System.Drawing.Point(46, 353);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(59, 21);
            this.label_phone.TabIndex = 17;
            this.label_phone.Text = "Phone";
            // 
            // tb_phone
            // 
            this.tb_phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_phone.Location = new System.Drawing.Point(158, 353);
            this.tb_phone.MaxLength = 16;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(171, 20);
            this.tb_phone.TabIndex = 3;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // label_infotext
            // 
            this.label_infotext.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infotext.Location = new System.Drawing.Point(49, 168);
            this.label_infotext.Name = "label_infotext";
            this.label_infotext.Size = new System.Drawing.Size(727, 95);
            this.label_infotext.TabIndex = 20;
            this.label_infotext.Text = resources.GetString("label_infotext.Text");
            this.label_infotext.UseCompatibleTextRendering = true;
            // 
            // label_subheading
            // 
            this.label_subheading.AutoSize = true;
            this.label_subheading.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subheading.Location = new System.Drawing.Point(44, 131);
            this.label_subheading.Name = "label_subheading";
            this.label_subheading.Size = new System.Drawing.Size(168, 28);
            this.label_subheading.TabIndex = 21;
            this.label_subheading.Text = "Report an issue";
            this.label_subheading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_reason
            // 
            this.label_reason.AutoSize = true;
            this.label_reason.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reason.Location = new System.Drawing.Point(45, 507);
            this.label_reason.Name = "label_reason";
            this.label_reason.Size = new System.Drawing.Size(246, 21);
            this.label_reason.TabIndex = 23;
            this.label_reason.Text = "Describe the issue in full detail:";
            // 
            // tb_reason
            // 
            this.tb_reason.Location = new System.Drawing.Point(49, 544);
            this.tb_reason.Multiline = true;
            this.tb_reason.Name = "tb_reason";
            this.tb_reason.Size = new System.Drawing.Size(694, 149);
            this.tb_reason.TabIndex = 6;
            this.tb_reason.TextChanged += new System.EventHandler(this.tb_reason_TextChanged);
            // 
            // tb_subject
            // 
            this.tb_subject.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_subject.Location = new System.Drawing.Point(50, 434);
            this.tb_subject.MaxLength = 64;
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(279, 20);
            this.tb_subject.TabIndex = 5;
            this.tb_subject.TextChanged += new System.EventHandler(this.tb_subject_TextChanged);
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_subject.Location = new System.Drawing.Point(46, 403);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(70, 21);
            this.label_subject.TabIndex = 25;
            this.label_subject.Text = "Subject:";
            // 
            // PropertyServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 768);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.tb_reason);
            this.Controls.Add(this.label_reason);
            this.Controls.Add(this.label_subheading);
            this.Controls.Add(this.label_infotext);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.group_topic);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_title);
            this.MaximumSize = new System.Drawing.Size(804, 807);
            this.MinimumSize = new System.Drawing.Size(804, 807);
            this.Name = "PropertyServiceRequest";
            this.TopMost = true;
            this.group_topic.ResumeLayout(false);
            this.group_topic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.RadioButton radio_topic_general;
        private System.Windows.Forms.GroupBox group_topic;
        private System.Windows.Forms.RadioButton radio_topic_feedback;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label error_text;
        private System.Windows.Forms.RadioButton radio_topic_safety;
        private System.Windows.Forms.RadioButton radio_topic_problem;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label_infotext;
        private System.Windows.Forms.Label label_subheading;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.TextBox tb_reason;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label label_subject;
    }
}

