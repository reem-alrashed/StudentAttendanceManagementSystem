namespace StudentAttendanceSystem
{
    partial class AttendanceStudents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 317);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.SystemColors.Info;
            this.btn_attendance.Enabled = false;
            this.btn_attendance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_attendance.Location = new System.Drawing.Point(322, 488);
            this.btn_attendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(330, 55);
            this.btn_attendance.TabIndex = 15;
            this.btn_attendance.Text = "Mark students attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(18, 580);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "back";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(315, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "Course:";
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(435, 55);
            this.comboBox_course.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(180, 28);
            this.comboBox_course.TabIndex = 48;
            this.comboBox_course.Text = "         <<select>>";
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged);
            // 
            // AttendanceStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(993, 634);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AttendanceStudents";
            this.Text = "AttendanceStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_course;
    }
}