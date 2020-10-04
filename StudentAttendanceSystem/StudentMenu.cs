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
    public partial class StudentMenu : Form
    {
        int studentID;
        DataClasses1DataContext db;
        int[] courseIdes;
        int[] courseContactHour; 

        public StudentMenu(int studentID)
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            this.studentID = studentID;
            loadStudentCourses();
        }
        private void loadStudentCourses()
        {
            var list = from a in db.Attendances
                       join c in db.Courses on a.CourseID equals c.id
                       where a.StudentID==studentID
                       select new { c.CourseName, c.id, c.ContactHours };

            courseIdes = new int[list.Count()];
            courseContactHour = new int[list.Count()];
            int index = 0;
            foreach (var elem in list)
            {
                comboBox.Items.Add(elem.CourseName);
                courseIdes[index] = elem.id;
                courseContactHour[index] = elem.ContactHours;
                index++;
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox.SelectedIndex > -1)
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
            }
        }
            //Absence Hours
        private void btn1_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (comboBox.SelectedIndex > -1)
            {
                int cID = courseIdes[comboBox.SelectedIndex];
                int contacthour = courseContactHour[comboBox.SelectedIndex];
                var query = from elem in db.Attendances
                            where (elem.CourseID == cID&&elem.StudentID==studentID)// match the ecords.
                            select new { elem.StudentID, elem.StudentHours };
                var x = query.ToList().ElementAt(0);
                int absenceHour = (contacthour - x.StudentHours);
                MessageBox.Show("Number Of absence hour: " + absenceHour, "Absence hour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (comboBox.SelectedIndex > -1)
            {
                int cID = courseIdes[comboBox.SelectedIndex];
                int contacthour = courseContactHour[comboBox.SelectedIndex];
                var query = from elem in db.Attendances
                            where (elem.CourseID == cID && elem.StudentID == studentID)// match the ecords.
                            select new { elem.StudentID, elem.StudentHours };
                var x = query.ToList().ElementAt(0);
                double AttendanceRate = (x.StudentHours /(double) contacthour) * 100;
                double absenceRate = (100 - AttendanceRate);
                MessageBox.Show("Absence Rate: " + absenceRate.ToString("0.00") + "%", "Absence Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                  
            }
        }

    }
}
