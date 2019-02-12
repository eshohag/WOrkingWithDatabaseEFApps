using System;
using System.Windows.Forms;
using WOrkingWithDatabaseEFApps.BAL;
using WOrkingWithDatabaseEFApps.DAL.Model;

namespace WOrkingWithDatabaseEFApps.UI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            ProgressbarForm aProgressbarForm = new ProgressbarForm();
            aProgressbarForm.Hide();
            GetAllStudents();
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student()
            {
                Name = nameTextBox.Text,
                ContactNo = contactNoTextBox.Text
            };

            SaveStudent aSaveStudent = new SaveStudent();
            resultLabel.Text = aSaveStudent.Save(aStudent);

            GetAllStudents();
        }

        private void GetAllStudents()
        {
            StudentBAL aStudentBal = new StudentBAL();
            studentDataGridView.DataSource = aStudentBal.GetMoreThenOneStudent();
        }
    }
}
