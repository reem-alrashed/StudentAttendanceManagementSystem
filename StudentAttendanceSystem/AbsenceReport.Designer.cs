namespace StudentAttendanceSystem
{
    partial class AbsenceReport
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(99, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "Course:";
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(219, 109);
            this.comboBox_course.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(180, 28);
            this.comboBox_course.TabIndex = 48;
            this.comboBox_course.Text = "         <<select>>";
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged);
            // 
            // Btn
            // 
            this.Btn.Enabled = false;
            this.Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn.Location = new System.Drawing.Point(135, 281);
            this.Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(336, 62);
            this.Btn.TabIndex = 50;
            this.Btn.Text = "Generate Abcence Report";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // AbsenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(714, 509);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_course);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AbsenceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbsenceReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Button Btn;
    }
}