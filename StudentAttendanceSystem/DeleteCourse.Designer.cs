namespace StudentAttendanceSystem
{
    partial class DeleteCourse
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
            this.addcourseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(118, 78);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(121, 21);
            this.comboBox_course.TabIndex = 0;
            this.comboBox_course.Text = "         <<select>>";
            // 
            // addcourseBtn
            // 
            this.addcourseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcourseBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.addcourseBtn.Location = new System.Drawing.Point(90, 184);
            this.addcourseBtn.Name = "addcourseBtn";
            this.addcourseBtn.Size = new System.Drawing.Size(174, 40);
            this.addcourseBtn.TabIndex = 37;
            this.addcourseBtn.Text = "Delete";
            this.addcourseBtn.UseVisualStyleBackColor = true;
            this.addcourseBtn.Click += new System.EventHandler(this.deletecourseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Course:";
            // 
            // DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addcourseBtn);
            this.Controls.Add(this.comboBox_course);
            this.Name = "DeleteCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Button addcourseBtn;
        private System.Windows.Forms.Label label1;
    }
}