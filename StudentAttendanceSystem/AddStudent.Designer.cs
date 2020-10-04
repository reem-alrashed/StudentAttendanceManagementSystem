namespace StudentAttendanceSystem
{
    partial class AddStudent
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
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addTraineeBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.cn_label = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(158, 235);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 20);
            this.birthDate.TabIndex = 29;
            this.birthDate.Value = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(68, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Birth Date:";
            // 
            // addTraineeBtn
            // 
            this.addTraineeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTraineeBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.addTraineeBtn.Location = new System.Drawing.Point(158, 272);
            this.addTraineeBtn.Name = "addTraineeBtn";
            this.addTraineeBtn.Size = new System.Drawing.Size(200, 40);
            this.addTraineeBtn.TabIndex = 30;
            this.addTraineeBtn.Text = "Add";
            this.addTraineeBtn.UseVisualStyleBackColor = true;
            this.addTraineeBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox.Location = new System.Drawing.Point(158, 165);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(200, 21);
            this.comboBox.TabIndex = 27;
            this.comboBox.Text = "                         <select>";
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(158, 200);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(200, 20);
            this.textBox_phonenumber.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(42, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "PhoneNumber:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(85, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Gender:";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(158, 126);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(200, 20);
            this.textBox_address.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(79, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Address:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(158, 91);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 20);
            this.textBox_name.TabIndex = 25;
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cn_label.Location = new System.Drawing.Point(93, 92);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(49, 19);
            this.cn_label.TabIndex = 31;
            this.cn_label.Text = "Name:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(158, 57);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(200, 20);
            this.textBox_password.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(68, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Password:";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(158, 26);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(200, 20);
            this.textBox_userName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(62, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "UserName:";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(466, 379);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addTraineeBtn);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox_phonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.cn_label);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addTraineeBtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label cn_label;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label6;
    }
}