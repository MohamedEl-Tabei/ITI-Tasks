using Microsoft.Data.SqlClient;
using System.Data;
using System.Data;
namespace ITI_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            GetAllStudent();
        }

       
        private void GetAllStudent()
        {
            SqlConnection conn = new SqlConnection("server=.;Database=iti;Trusted_connection=true;trustserverCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Student";
            command.Connection = conn;
            try {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                gridStudent.DataSource = dt;
            }
            catch { }
            finally {
                conn.Close();
            }
        }
    }
}
