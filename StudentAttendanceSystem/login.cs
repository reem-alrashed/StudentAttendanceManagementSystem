using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class LoginForm : Form
    {
        DataClasses1DataContext db;
        public LoginForm()
        {
            InitializeComponent();
            comboBox.Text = "Teacher";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (comboBox.Text == "Teacher")
            {
                var tQuery = from t in db.Teachers
                                             where ((t.username == textBox_username.Text) && (t.password == textBox_password.Text))
                                             select t;
                if (tQuery.Count() != 0)
                {
                    TeacherMenu f = new TeacherMenu();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Error In username or password!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox.Text == "Student")
            {
               var sQuery = from s in db.Students
                                             where ((s.username == textBox_username.Text) && (s.password == textBox_password.Text))
                                             select s;
                if (sQuery.Count() != 0)
                {
                    int studentID= sQuery.ToList().ElementAt(0).id;
                    StudentMenu f = new StudentMenu(studentID);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Error In username or password!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
