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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db;
            try
            {
                db = new DataClasses1DataContext();
                /*
                    * picking Student's information from the Form
                 */
                Student s = new Student();
                s.username = textBox_userName.Text;
                s.password = textBox_password.Text;
                s.Name = textBox_name.Text;
                s.Address = textBox_address.Text;
                s.Gender = comboBox.Text;
                s.Phone = textBox_phonenumber.Text;
                s.BirthDate = birthDate.Value;
                db.Students.InsertOnSubmit(s);//InsertOnSubmit queries will automatic call thats the data context class handle it.
                db.SubmitChanges();
                MessageBox.Show("Student has been added successfully ..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Exception caught: " + ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
