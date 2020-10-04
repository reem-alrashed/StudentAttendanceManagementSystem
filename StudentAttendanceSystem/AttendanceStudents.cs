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
    public partial class AttendanceStudents : Form
    {
        DataClasses1DataContext db;
        int[] courseIdes;
        int[] courseHourSession;
        int[] SectionIdes;
        DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();

        int cID=-1;
        int hourPerSession=0;
        List<int> std = new List<int>(); //students who we want t mark them as attedance for this session

        bool addchek = false;
        public AttendanceStudents()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            loadCourses();
        }
        private void loadCourses()
        {
            var list = from x in db.Courses
                       orderby x.CourseName ascending
                       select new { x.CourseName, x.id,x.HoursPerSession };
            courseIdes = new int[list.Count()];
            courseHourSession = new int[list.Count()];
            int index = 0;
            foreach (var elem in list)
            {
                comboBox_course.Items.Add(elem.CourseName);
                courseIdes[index] = elem.id;
                courseHourSession[index] = elem.HoursPerSession;
                index++;
            }
        }

        private void loadSections()
        {

            var list = from x in db.Section

                       orderby x.SectionName ascending

                       select new { x.SectionName, x.SectionID };

            SectionIdes = new int[list.Count()];



            int index = 0;

            foreach (var elem in list)
            {

                comboBox1.Items.Add(elem.SectionName);

                courseIdes[index] = elem.SectionID;



                index++;

            }

        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            db = new DataClasses1DataContext();
            if (comboBox_course.SelectedIndex > -1)
            {
                cID = courseIdes[comboBox_course.SelectedIndex];
                hourPerSession = courseHourSession[comboBox_course.SelectedIndex];
                btn_attendance.Enabled = true;
                var list = (from a in db.Attendances
                            join s in db.Students on a.StudentID equals s.id
                            where a.CourseID == cID
                            select new {s.id, s.Name, s.Address, s.Phone, s.BirthDate });
               
                dataGridView1.DataSource = list;
                if (addchek == false)
                {
                    dataGridView1.Columns.Add(check);
                    check.HeaderText = "Select Student";
                    check.Name = "check";
                    addchek = true;
                }
                
            }
            else
            {
                MessageBox.Show("you must choose Course from ComboBox !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<int> indexes = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[check.Name].Value) == true)
                {
                    std.Insert(std.Count, Convert.ToInt32(row.Cells["Id"].Value));
                }
                i++;
            }
            string s = "";
            foreach (int id in std)
            {
                db = new DataClasses1DataContext();
                s += id+"\n";
                //Update student attendance//<---------------------
                var update = from elem in db.Attendances
                             where (elem.StudentID == id && elem.CourseID==cID )// match the ecords.
                             select elem;
                Attendance a = update.ToList().ElementAt(0);
                a.StudentHours = a.StudentHours + hourPerSession;
                a.LatestDate = DateTime.Now;
                db.SubmitChanges();

            }
            db = new DataClasses1DataContext();
            //update course Contact Hours//
            var updateC = from elem in db.Courses
                         where (elem.id == cID)// match the ecords.
                         select elem;
            Course c= updateC.ToList().ElementAt(0);
            c.ContactHours = c.ContactHours + hourPerSession;
            db.SubmitChanges();
            //MessageBox.Show(s);
            MessageBox.Show("Students has Marked thier Attendance successfully ..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
