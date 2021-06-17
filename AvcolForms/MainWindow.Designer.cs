
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.img_avcolformslogo = new System.Windows.Forms.PictureBox();
            this.logo_container = new System.Windows.Forms.Panel();
            this.text_logo = new System.Windows.Forms.Label();
            this.panel_accountype = new System.Windows.Forms.Panel();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.panel_initalscreen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img_avcolformslogo)).BeginInit();
            this.logo_container.SuspendLayout();
            this.panel_accountype.SuspendLayout();
            this.panel_initalscreen.SuspendLayout();
            this.SuspendLayout();
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
            this.logo_container.Location = new System.Drawing.Point(90, 12);
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
            // panel_accountype
            // 
            this.panel_accountype.Controls.Add(this.btn_teacher);
            this.panel_accountype.Controls.Add(this.btn_student);
            this.panel_accountype.Location = new System.Drawing.Point(93, 182);
            this.panel_accountype.Name = "panel_accountype";
            this.panel_accountype.Size = new System.Drawing.Size(581, 213);
            this.panel_accountype.TabIndex = 4;
            // 
            // btn_teacher
            // 
            this.btn_teacher.BackColor = System.Drawing.SystemColors.Window;
            this.btn_teacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_teacher.BackgroundImage")));
            this.btn_teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher.Location = new System.Drawing.Point(394, 55);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(130, 137);
            this.btn_teacher.TabIndex = 1;
            this.btn_teacher.Text = "Teacher";
            this.btn_teacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_teacher.UseVisualStyleBackColor = false;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.SystemColors.Window;
            this.btn_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_student.BackgroundImage")));
            this.btn_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Location = new System.Drawing.Point(80, 55);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(130, 137);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "Student";
            this.btn_student.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // panel_initalscreen
            // 
            this.panel_initalscreen.Controls.Add(this.panel_accountype);
            this.panel_initalscreen.Controls.Add(this.logo_container);
            this.panel_initalscreen.Location = new System.Drawing.Point(-2, 0);
            this.panel_initalscreen.Name = "panel_initalscreen";
            this.panel_initalscreen.Size = new System.Drawing.Size(805, 454);
            this.panel_initalscreen.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_initalscreen);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.Text = "Avcol Forms";
            ((System.ComponentModel.ISupportInitialize)(this.img_avcolformslogo)).EndInit();
            this.logo_container.ResumeLayout(false);
            this.logo_container.PerformLayout();
            this.panel_accountype.ResumeLayout(false);
            this.panel_initalscreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox img_avcolformslogo;
        private System.Windows.Forms.Panel logo_container;
        private System.Windows.Forms.Label text_logo;
        private System.Windows.Forms.Panel panel_accountype;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Panel panel_initalscreen;
    }
}