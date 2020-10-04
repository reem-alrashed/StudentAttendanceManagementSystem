namespace StudentAttendanceSystem
{
    partial class TeacherMenu
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
            this.addcourseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addTraineeBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addcourseBtn
            // 
            this.addcourseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcourseBtn.ForeColor = System.Drawing.Color.Black;
            this.addcourseBtn.Location = new System.Drawing.Point(59, 45);
            this.addcourseBtn.Name = "addcourseBtn";
            this.addcourseBtn.Size = new System.Drawing.Size(258, 40);
            this.addcourseBtn.TabIndex = 2;
            this.addcourseBtn.Text = "Add Course";
            this.addcourseBtn.UseVisualStyleBackColor = true;
            this.addcourseBtn.Click += new System.EventHandler(this.addcourseBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(59, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(59, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addTraineeBtn
            // 
            this.addTraineeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTraineeBtn.ForeColor = System.Drawing.Color.Black;
            this.addTraineeBtn.Location = new System.Drawing.Point(59, 183);
            this.addTraineeBtn.Name = "addTraineeBtn";
            this.addTraineeBtn.Size = new System.Drawing.Size(258, 40);
            this.addTraineeBtn.TabIndex = 5;
            this.addTraineeBtn.Text = "Add Student";
            this.addTraineeBtn.UseVisualStyleBackColor = true;
            this.addTraineeBtn.Click += new System.EventHandler(this.addTraineeBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(59, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Register Student In Course";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(59, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Attendance Students";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(59, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Generate Absence Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(394, 431);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addTraineeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addcourseBtn);
            this.Name = "TeacherMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addcourseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addTraineeBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}