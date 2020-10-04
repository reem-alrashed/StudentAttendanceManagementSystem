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
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void addcourseBtn_Click(object sender, EventArgs e)
        {
            AddCourse f = new AddCourse();
            f.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCourse f = new DeleteCourse();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCourse f = new UpdateCourse();
            f.Show();
        }

        private void addTraineeBtn_Click(object sender, EventArgs e)
        {
            AddStudent f = new AddStudent();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AttendanceStudents f = new AttendanceStudents();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbsenceReport f = new AbsenceReport();
            f.Show();
        }
    }
}
