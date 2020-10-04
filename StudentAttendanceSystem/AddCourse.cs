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
    public partial class AddCourse : Form
    {
        DataClasses1DataContext db;
        public AddCourse()
        {
            InitializeComponent();
        }

        private void addcourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DataClasses1DataContext();
                /*
                    * picking customer's information from the Form
                 */
                Course c = new Course();
                c.CourseName = textBox_name.Text;
                c.Hours = Convert.ToInt32(textBox_hours.Text);
                c.HoursPerSession = Convert.ToInt32(textBox_hoursPerSession.Text);
                if (textBox_contactHours.Text == "")
                    c.ContactHours = 0;
                else
                    c.ContactHours = Convert.ToInt32(textBox_contactHours.Text);
                c.Section = comboBox.Text;

                db.Courses.InsertOnSubmit(c);//InsertOnSubmit queries will automatic call thats the data context class handle it.
                db.SubmitChanges();
                MessageBox.Show("Course has been added successfully ..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("input is invalid!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Exception caught: " + ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
