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
    public partial class frmStudentByDpt : Form
    {
        public frmStudentByDpt()
        {
            InitializeComponent();
            FillDepartmentCombobox();
           
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

        

        

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection("server=.;database=iti;trusted_connection=true;trustservercertificate=true");
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT S.* FROM Student S , Department D WHERE S.Dept_id=D.Dept_id AND D.Dept_id=@id";
            command.Connection = connection;
            command.Parameters.AddWithValue("id", cbDepartment.SelectedValue.ToString());
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                gridStudents.DataSource = dt;
            }
            catch { }
            finally
            {
                connection.Close();
            }
        }
    }
}
