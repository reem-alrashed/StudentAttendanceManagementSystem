namespace StudentAttendanceSystem
{
    partial class UpdateCourse
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
            this.textBox_contactHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_hoursPerSession = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.cn_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.updatecourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_contactHours
            // 
            this.textBox_contactHours.Enabled = false;
            this.textBox_contactHours.Location = new System.Drawing.Point(414, 163);
            this.textBox_contactHours.Name = "textBox_contactHours";
            this.textBox_contactHours.Size = new System.Drawing.Size(166, 20);
            this.textBox_contactHours.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(309, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Contact Hours:";
            // 
            // textBox_hoursPerSession
            // 
            this.textBox_hoursPerSession.Enabled = false;
            this.textBox_hoursPerSession.Location = new System.Drawing.Point(137, 162);
            this.textBox_hoursPerSession.Name = "textBox_hoursPerSession";
            this.textBox_hoursPerSession.Size = new System.Drawing.Size(166, 20);
            this.textBox_hoursPerSession.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.Enabled = false;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "English Section",
            "Math Section",
            "Computer Science",
            "Information Technology",
            "Computer Engineering"});
            this.comboBox.Location = new System.Drawing.Point(230, 218);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(166, 21);
            this.comboBox.TabIndex = 6;
            this.comboBox.Text = "                 <select>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(167, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Section:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(7, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hours Per Session:";
            // 
            // textBox_hours
            // 
            this.textBox_hours.Enabled = false;
            this.textBox_hours.Location = new System.Drawing.Point(414, 116);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(166, 20);
            this.textBox_hours.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(311, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Course Hours:";
            // 
            // textBox_name
            // 
            this.textBox_name.Enabled = false;
            this.textBox_name.Location = new System.Drawing.Point(139, 118);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(166, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cn_label.Location = new System.Drawing.Point(7, 117);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(97, 19);
            this.cn_label.TabIndex = 41;
            this.cn_label.Text = "Course Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(150, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Course:";
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(230, 48);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(121, 21);
            this.comboBox_course.TabIndex = 1;
            this.comboBox_course.Text = "         <<select>>";
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged);
            // 
            // updatecourseBtn
            // 
            this.updatecourseBtn.Enabled = false;
            this.updatecourseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecourseBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.updatecourseBtn.Location = new System.Drawing.Point(203, 281);
            this.updatecourseBtn.Name = "updatecourseBtn";
            this.updatecourseBtn.Size = new System.Drawing.Size(174, 40);
            this.updatecourseBtn.TabIndex = 7;
            this.updatecourseBtn.Text = "Update";
            this.updatecourseBtn.UseVisualStyleBackColor = true;
            this.updatecourseBtn.Click += new System.EventHandler(this.updatecourseBtn_Click);
            // 
            // UpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(604, 391);
            this.Controls.Add(this.updatecourseBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.textBox_contactHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hoursPerSession);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.cn_label);
            this.Name = "UpdateCourse";
            this.Text = "UpdateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_contactHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_hoursPerSession;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label cn_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Button updatecourseBtn;
    }
}