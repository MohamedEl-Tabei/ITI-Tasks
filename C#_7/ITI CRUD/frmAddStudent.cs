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
    public partial class frmAddStudent : Form
    {
        public int id { get; set; } = 20;
        public frmAddStudent()
        {
            InitializeComponent();
            FillDepartmentCombobox();
            FillStudentCombobox();
        }

        private void FillStudentCombobox()
        {
            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT st_fname+' '+st_lname AS Name FROM Student";
            command.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbStudents.DataSource = dt;
                cbStudents.DisplayMember = "Name";
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
                id = dt.Rows.Count + 20;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Student (st_id,st_fname,st_lname,st_address,st_age,Dept_id,st_super) values(@st_id,@st_fname,@st_lname,@st_address,@st_age,@dept_id,1)";
            command.Parameters.AddWithValue("@st_fname", txtFName.Text.ToString());
            command.Parameters.AddWithValue("@st_lname", txtLName.Text.ToString());
            command.Parameters.AddWithValue("@st_address", txtAddress.Text.ToString());
            command.Parameters.AddWithValue("@st_age", txtAge.Text.ToString());
            command.Parameters.AddWithValue("@dept_id", cbDepartment.SelectedValue.ToString());
            command.Parameters.AddWithValue("@st_id", id++);

            command.Connection = conn;
            try
            {
                conn.Open();
                txtStatus.Text = $"{command.ExecuteNonQuery()} Student Added.";
                FillStudentCombobox(); 
                txtFName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtAge.Text = "";
            }
            //catch { }
            finally
            {
                conn.Close();
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }
    }

}
