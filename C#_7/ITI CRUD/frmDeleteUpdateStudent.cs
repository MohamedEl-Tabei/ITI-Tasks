using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ITI_CRUD
{
    public partial class frmDeleteUpdateStudent : Form
    {
        public frmDeleteUpdateStudent()
        {
            InitializeComponent();
            FillStudentCombobox();
            FillDepartmentCombobox();
        }
        private void FillStudentCombobox()
        {
            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT st_id,st_fname+' '+st_lname AS Name FROM Student";
            command.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbStudents.DataSource = dt;
                cbStudents.DisplayMember = "Name";
                cbStudents.ValueMember = "st_id";
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void FillDepartmentCombobox()
        {
            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Dept_id,Dept_name FROM Department";
            command.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbDepartment.DataSource = dt;
                cbDepartment.DisplayMember = "Dept_name";
                cbDepartment.ValueMember = "Dept_id";
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Student WHERE st_id=@id";
            command.Parameters.AddWithValue("@id", cbStudents.SelectedValue);
            command.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                txtFName.Text = dt.Rows[0]["st_fname"].ToString();
                txtLName.Text = dt.Rows[0]["st_lname"].ToString();
                txtAddress.Text = dt.Rows[0]["st_address"].ToString();
                txtAge.Text = dt.Rows[0]["st_age"].ToString();
                cbDepartment.SelectedValue = dt.Rows[0]["Dept_id"].ToString();

            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Student SET st_fname=@st_fname,st_lname=@st_lname,st_address=@st_address,st_age=@st_age,dept_id=@dept_id WHERE st_id=@st_id";
            command.Parameters.AddWithValue("@st_fname", txtFName.Text.ToString());
            command.Parameters.AddWithValue("@st_lname", txtLName.Text.ToString());
            command.Parameters.AddWithValue("@st_address", txtAddress.Text.ToString());
            command.Parameters.AddWithValue("@st_age", txtAge.Text.ToString());
            command.Parameters.AddWithValue("@dept_id", cbDepartment.SelectedValue.ToString());
            command.Parameters.AddWithValue("@st_id", cbStudents.SelectedValue);

            command.Connection = conn;
            try
            {
                conn.Open();
                txtStatus.Text = $"{command.ExecuteNonQuery()} Student Updated.";
                FillStudentCombobox();

            }
            //catch { }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want delete {txtFName.Text} {txtLName.Text}","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE From Student WHERE st_id=@st_id";
                command.Parameters.AddWithValue("@st_id", cbStudents.SelectedValue);

                command.Connection = conn;
                try
                {
                    conn.Open();
                    txtStatus.Text = $"{command.ExecuteNonQuery()} Student Deleted.";
                    FillStudentCombobox();

                }
                //catch { }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
