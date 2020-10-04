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
    public partial class AbsenceReport : Form
    {
        DataClasses1DataContext db;
        int[] courseIdes;
        int[] courseContactHour; 
        public AbsenceReport()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            loadCourses();
        }
        private void loadCourses()
        {
            var list = from x in db.Courses
                       orderby x.CourseName ascending
                       select new { x.CourseName, x.id ,x.ContactHours};
            courseIdes = new int[list.Count()];
            courseContactHour =new int[list.Count()];
            int index = 0;
            foreach (var elem in list)
            {
                comboBox_course.Items.Add(elem.CourseName);
                courseIdes[index] = elem.id;
                courseContactHour[index] = elem.ContactHours;
                index++;
            }
        }
        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_course.SelectedIndex > -1)
            {
                Btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (comboBox_course.SelectedIndex > -1)
            {
                int cID = courseIdes[comboBox_course.SelectedIndex];
                int contacthour = courseContactHour[comboBox_course.SelectedIndex];
                var query = from elem in db.Attendances
                            where (elem.CourseID == cID)// match the ecords.
                            select new { elem.StudentID ,elem.StudentHours};
                if (query.Count() > 0)
                {
                    bool exist = false;
                    string students = "";
                    foreach (var x in query)
                    {
                        double AttendanceRate=(x.StudentHours/(double)contacthour)*100;
                        double absenceRate=(100-AttendanceRate);
                        if (absenceRate >= 25)
                        {
                            exist = true;
                            var qStd = from elem in db.Students
                                          where (elem.id == x.StudentID)// match the records
                                          select elem;
                            Student s = qStd.ToList().ElementAt(0);
                            students += "Name: " + s.Name + ", ID: " + s.id + ", number Of absence hour: " + (contacthour - x.StudentHours) + ", Absence Rate: " + absenceRate.ToString("0.00") + "%\n";
                        }
                    }
                    if (exist)
                    {
                        MessageBox.Show("The Following students have 25% absence or more: \n" + students, "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No one of students have rate more than 25%", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("There are no students registerd in this course yet", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
