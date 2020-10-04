namespace StudentAttendanceSystem
{
    partial class AddCourse
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
            this.textBox_hoursPerSession = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.cn_label = new System.Windows.Forms.Label();
            this.textBox_contactHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addcourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_hoursPerSession
            // 
            this.textBox_hoursPerSession.Location = new System.Drawing.Point(143, 87);
            this.textBox_hoursPerSession.Name = "textBox_hoursPerSession";
            this.textBox_hoursPerSession.Size = new System.Drawing.Size(166, 20);
            this.textBox_hoursPerSession.TabIndex = 28;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "English Section",
            "Math Section",
            "Computer Science",
            "Information Technology",
            "Computer Engineering"});
            this.comboBox.Location = new System.Drawing.Point(236, 143);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(166, 21);
            this.comboBox.TabIndex = 30;
            this.comboBox.Text = "                 <select>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(173, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Section:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hours Per Session:";
            // 
            // textBox_hours
            // 
            this.textBox_hours.Location = new System.Drawing.Point(420, 41);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(166, 20);
            this.textBox_hours.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(317, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Course Hours:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(145, 43);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(166, 20);
            this.textBox_name.TabIndex = 26;
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cn_label.Location = new System.Drawing.Point(13, 42);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(97, 19);
            this.cn_label.TabIndex = 30;
            this.cn_label.Text = "Course Name:";
            // 
            // textBox_contactHours
            // 
            this.textBox_contactHours.Location = new System.Drawing.Point(420, 88);
            this.textBox_contactHours.Name = "textBox_contactHours";
            this.textBox_contactHours.Size = new System.Drawing.Size(166, 20);
            this.textBox_contactHours.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(315, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Contact Hours:";
            // 
            // addcourseBtn
            // 
            this.addcourseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcourseBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.addcourseBtn.Location = new System.Drawing.Point(167, 218);
            this.addcourseBtn.Name = "addcourseBtn";
            this.addcourseBtn.Size = new System.Drawing.Size(258, 40);
            this.addcourseBtn.TabIndex = 36;
            this.addcourseBtn.Text = "Add";
            this.addcourseBtn.UseVisualStyleBackColor = true;
            this.addcourseBtn.Click += new System.EventHandler(this.addcourseBtn_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(610, 302);
            this.Controls.Add(this.addcourseBtn);
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
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hoursPerSession;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label cn_label;
        private System.Windows.Forms.TextBox textBox_contactHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addcourseBtn;
    }
}