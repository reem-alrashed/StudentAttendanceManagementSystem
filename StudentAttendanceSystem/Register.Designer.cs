namespace StudentAttendanceSystem
{
    partial class Register
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
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_student = new System.Windows.Forms.ComboBox();
            this.cn_label = new System.Windows.Forms.Label();
            this.comboBox_teacher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addregBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(104, 106);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(191, 21);
            this.comboBox_course.TabIndex = 3;
            this.comboBox_course.Text = "                   <select>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(42, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Course:";
            // 
            // comboBox_student
            // 
            this.comboBox_student.FormattingEnabled = true;
            this.comboBox_student.Location = new System.Drawing.Point(104, 52);
            this.comboBox_student.Name = "comboBox_student";
            this.comboBox_student.Size = new System.Drawing.Size(191, 21);
            this.comboBox_student.TabIndex = 1;
            this.comboBox_student.Text = "                   <select>";
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cn_label.Location = new System.Drawing.Point(42, 51);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(58, 19);
            this.cn_label.TabIndex = 32;
            this.cn_label.Text = "Student:";
            // 
            // comboBox_teacher
            // 
            this.comboBox_teacher.FormattingEnabled = true;
            this.comboBox_teacher.Location = new System.Drawing.Point(104, 79);
            this.comboBox_teacher.Name = "comboBox_teacher";
            this.comboBox_teacher.Size = new System.Drawing.Size(191, 21);
            this.comboBox_teacher.TabIndex = 2;
            this.comboBox_teacher.Text = "                   <select>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Teacher:";
            // 
            // addregBtn
            // 
            this.addregBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addregBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.addregBtn.Location = new System.Drawing.Point(85, 196);
            this.addregBtn.Name = "addregBtn";
            this.addregBtn.Size = new System.Drawing.Size(200, 40);
            this.addregBtn.TabIndex = 4;
            this.addregBtn.Text = "Registrer";
            this.addregBtn.UseVisualStyleBackColor = true;
            this.addregBtn.Click += new System.EventHandler(this.addregBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(370, 279);
            this.Controls.Add(this.addregBtn);
            this.Controls.Add(this.comboBox_teacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_student);
            this.Controls.Add(this.cn_label);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_student;
        private System.Windows.Forms.Label cn_label;
        private System.Windows.Forms.ComboBox comboBox_teacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addregBtn;
    }
}