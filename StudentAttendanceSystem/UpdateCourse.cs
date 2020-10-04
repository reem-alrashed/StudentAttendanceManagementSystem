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
    public partial class UpdateCourse : Form
    {
        DataClasses1DataContext db;
        int[] courseIdes;
        public UpdateCourse()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            loadCourses();
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

        private void updatecourseBtn_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (comboBox_course.SelectedIndex > -1)
            {
                int cID = courseIdes[comboBox_course.SelectedIndex];
                var update = from elem in db.Courses
                             where elem.id == cID// match the ecords.
                             select elem;
                Course c = update.ToList().ElementAt(0);
                c.CourseName = textBox_name.Text;
                c.Hours = Convert.ToInt32(textBox_hours.Text);
                c.HoursPerSession = Convert.ToInt32(textBox_hoursPerSession.Text);
                if (textBox_contactHours.Text == "")
                    c.ContactHours = 0;
                else
                    c.ContactHours = Convert.ToInt32(textBox_contactHours.Text);
                c.Section = comboBox.Text;
                db.SubmitChanges();
                MessageBox.Show("Course has updated successfully ..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void enableAll()
        {
            textBox_name.Enabled=true;
            textBox_hours.Enabled=true;
            textBox_hoursPerSession.Enabled=true;
            textBox_contactHours.Enabled=true;
            comboBox.Enabled = true;
            updatecourseBtn.Enabled= true;
            
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (comboBox_course.SelectedIndex > -1)
            {
                enableAll();
                int cID = courseIdes[comboBox_course.SelectedIndex];
                var load = from elem in db.Courses
                             where elem.id == cID// match the ecords.
                             select elem;
                Course c = load.ToList().ElementAt(0);
                textBox_name.Text  = c.CourseName;
                textBox_hours.Text=c.Hours+"";
                 textBox_hoursPerSession.Text= ""+c.HoursPerSession;
                 textBox_contactHours.Text = ""+c.ContactHours;
                 comboBox.Text= c.Section;
            }
            else
            {
                MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
