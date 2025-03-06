
using ITI.BusinessLayer;

namespace ITI.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillStudentList();
        }

        private void FillStudentList()
        {
            gridStudents.DataSource = ITI.BusinessLayer.StudentBL.GetAll();
            cbStudents.DataSource = ITI.BusinessLayer.StudentBL.GetAll();
            cbStudents.DisplayMember = "st_fname";
            cbStudents.ValueMember = "st_id";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var student = new Student()
            {
                Age = txtAge.Text,
                Dept_ID = txtDepartment.Text,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Id = (gridStudents.Rows.Count + 1).ToString(),
                Address = txtAddress.Text,
            };
            txtStatus.Text = $"{ITI.BusinessLayer.StudentBL.Add(student)} row Added";
            FillStudentList();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = new Student()
            {
                Age = txtAge.Text,
                Dept_ID = txtDepartment.Text,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Id = cbStudents.SelectedValue.ToString(),
                Address = txtAddress.Text,
            };
            txtStatus.Text = $"{ITI.BusinessLayer.StudentBL.Update(student)} row Updated";
            FillStudentList();
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student = ITI.BusinessLayer.StudentBL.GetOne(cbStudents.SelectedValue.ToString());
            txtAddress.Text = student.Rows[0]["st_address"].ToString();
            txtFName.Text = student.Rows[0]["st_fname"].ToString();
            txtLName.Text = student.Rows[0]["st_lname"].ToString();
            txtAge.Text = student.Rows[0]["st_age"].ToString();
            txtDepartment.Text = student.Rows[0]["Dept_id"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtStatus.Text = $"{ITI.BusinessLayer.StudentBL.Delete(cbStudents.SelectedValue.ToString())} row deleted";
            FillStudentList();
    }
    }
}
