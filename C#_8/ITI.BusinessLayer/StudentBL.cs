using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Data.SqlClient;

namespace ITI.BusinessLayer
{
    public class StudentBL
    {
        public static DataTable GetAll() => ITI.DataAccessLayer.DBManager.ExecuteQuery("SELECT * FROM Student");
        public static DataTable GetOne(string id) =>
            ITI.DataAccessLayer.DBManager.ExecuteQuery($"SELECT * FROM Student WHERE st_id='{id}'");
        public static int Add(Student student)
        {
            string query = "INSERT INTO Student (st_id,st_fname,st_lname,dept_id,st_age,st_address) VALUES(@id,@fname,@lname,@dptId,@age,@address)";
            SqlParameter[] parameters ={
            new SqlParameter("@id",student.Id),
            new SqlParameter("@fname", student.FName),
            new SqlParameter("@lname",student.LName),
            new SqlParameter("@age",student.Age),
            new SqlParameter("@address",  student.Address),
            new SqlParameter("@dptId",student.Dept_ID),
            };
            return ITI.DataAccessLayer.DBManager.ExecuteNonQuery(query, parameters);
        }
        public static int Update(Student student) {
            string query = "UPDATE Student SET st_fname=@fname,st_lname=@lname,dept_id=@dptId,st_age=@age,st_address=@address WHERE st_id=@id";
            SqlParameter[] parameters ={
            new SqlParameter("@id",student.Id),
            new SqlParameter("@fname", student.FName),
            new SqlParameter("@lname",student.LName),
            new SqlParameter("@age",student.Age),
            new SqlParameter("@address",  student.Address),
            new SqlParameter("@dptId",student.Dept_ID),
            };
            return ITI.DataAccessLayer.DBManager.ExecuteNonQuery(query, parameters);
        }
        public static int Delete(string id) =>
            ITI.DataAccessLayer.DBManager.ExecuteNonQuery("DELETE FROM Student WHERE st_id=@id", [new SqlParameter("@id",  id)]);
    }
}
