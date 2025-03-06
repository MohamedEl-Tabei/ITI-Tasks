
using System.Configuration;
using System.Data;
using System.Net;
using Microsoft.Data.SqlClient;

namespace C__8
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            var connectionStr = ConfigurationManager.ConnectionStrings["ITIDB"].ConnectionString;
            conn = new SqlConnection(connectionStr);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            dt = new DataTable();
            InitializeComponent();
            FillStudentsList();
            FillDepartmentList();
        }

        private void FillDepartmentList()
        {
            var dtDpt = new DataTable();
            cmd.CommandText = "SELECT * FROM Department";
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;
            adapter.Fill(dtDpt);
            cbDepartment.DataSource = dtDpt;
            cbDepartment.DisplayMember = "dept_name";
            cbDepartment.ValueMember = "dept_id";
        }

        private void FillStudentsList()
        {
            cmd.CommandText = "SELECT * From Student";
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;

            adapter.Fill(dt);
            gridStudents.DataSource = dt;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var dr = dt.NewRow();
            dr["st_id"] = dt.Rows.Count + 1;
            dr["st_fname"] = txtFName.Text;
            dr["st_lname"] = txtLName.Text;
            dr["st_age"] = txtAge.Value;
            dr["st_address"] = txtAddress.Text;
            dr["dept_id"] =cbDepartment.SelectedValue;
            dt.Rows.Add(dr);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            var InsCommand = new SqlCommand();
            InsCommand.CommandText = "INSERT INTO Student (st_id,st_fname,st_lname,dept_id,st_age,st_address) VALUES(@id,@fname,@lname,@dptId,@age,@address)";
            InsCommand.Parameters.Add("@id",SqlDbType.VarChar,50,"st_id");
            InsCommand.Parameters.Add("@fname", SqlDbType.VarChar,50, "st_fname");
            InsCommand.Parameters.Add("@lname", SqlDbType.VarChar,50, "st_lname");
            InsCommand.Parameters.Add("@age", SqlDbType.VarChar,50, "st_age");
            InsCommand.Parameters.Add("@address", SqlDbType.VarChar,50, "st_address");
            InsCommand.Parameters.Add("@dptId", SqlDbType.VarChar,50, "dept_id");
            InsCommand.Connection=conn;
            adapter.InsertCommand= InsCommand;
            //
            var UpdateCommand = new SqlCommand();
            UpdateCommand.CommandText = "UPDATE Student SET st_fname=@fname,st_lname=@lname,dept_id=@dptId,st_age=@age,st_address=@address WHERE st_id=@id";
            UpdateCommand.Parameters.Add("@id", SqlDbType.VarChar, 50, "st_id");
            UpdateCommand.Parameters.Add("@fname", SqlDbType.VarChar, 50, "st_fname");
            UpdateCommand.Parameters.Add("@lname", SqlDbType.VarChar, 50, "st_lname");
            UpdateCommand.Parameters.Add("@age", SqlDbType.VarChar, 50, "st_age");
            UpdateCommand.Parameters.Add("@address", SqlDbType.VarChar, 50, "st_address");
            UpdateCommand.Parameters.Add("@dptId", SqlDbType.VarChar, 50, "dept_id");
            UpdateCommand.Connection = conn;
            adapter.UpdateCommand = UpdateCommand;
            //
            var DeleteCommand = new SqlCommand();
            DeleteCommand.CommandText = "DELETE FROM Student WHERE st_id=@id";
            DeleteCommand.Parameters.Add("@id", SqlDbType.VarChar, 50, "st_id");
            DeleteCommand.Connection = conn;
            adapter.DeleteCommand = DeleteCommand;



            adapter.Update(dt);

        }
    }
}
