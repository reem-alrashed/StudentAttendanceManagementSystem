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
    public partial class Register : Form
    {
        DataClasses1DataContext db;
        int[] courseIdes;
        int[] studentIdes;
        int[] teacherIdes;

        public Register()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            loadStudents();
            loadTeachers();
            loadCourses();
        }
        private void loadStudents()
        {
            var list = from x in db.Students
                       orderby x.Name ascending
                       select new { x.Name, x.id };
            studentIdes = new int[list.Count()];
            int index = 0;
            foreach (var elem in list)
            {
                comboBox_student.Items.Add(elem.Name);
                studentIdes[index] = elem.id;
                index++;
            }
        }
        private void loadTeachers()
        {
            var list = from x in db.Teachers
                       orderby x.name ascending
                       select new { x.name, x.id };
            teacherIdes = new int[list.Count()];
            int index = 0;
            foreach (var elem in list)
            {
                comboBox_teacher.Items.Add(elem.name);
                teacherIdes[index] = elem.id;
                index++;
            }
        }
        private void loadCourses()
        {
            var list = from x in db.Courses
                       orderby x.CourseName ascending
                       select new { x.CourseName, x.id };
            courseIdes = new int[list.Count()];
            int index = 0;
            foreach (var elem in list)
            {
                comboBox_course.Items.Add(elem.CourseName);
                courseIdes[index] = elem.id;
                index++;
            }
        }

        private void addregBtn_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (comboBox_student.SelectedIndex > -1)
            {
                int sID = studentIdes[comboBox_student.SelectedIndex];
                if (comboBox_teacher.SelectedIndex > -1)
                {
                    int tID = teacherIdes[comboBox_teacher.SelectedIndex];
                    if (comboBox_course.SelectedIndex > -1)
                    {
                        int cID = courseIdes[comboBox_course.SelectedIndex];
                        db = new DataClasses1DataContext();
                        Attendance a = new Attendance();
                        a.StudentID = sID;
                        a.TeacherID = tID;
                        a.CourseID = cID;
                        DateTime currentDate = DateTime.Now;
                        a.LatestDate = currentDate;
                        a.StudentHours = 0;
                        db.Attendances.InsertOnSubmit(a);
                        db.SubmitChanges();
                        MessageBox.Show("Registration has been added successfully ..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            else
            {
                MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
