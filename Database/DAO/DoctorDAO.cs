using Database.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.DTO;
using System.Data;
using System.Data.SqlClient;

namespace Database.DAO
{
    public class DoctorDAO
    {
        private readonly DBConnection conn;
        public DoctorDAO()
        {
            conn = new DBConnection();
        }

        private Doctor GetDoctorFromDataRow(DataRow row)
        {
            Doctor Doctor = new Doctor();

            Doctor.Id = int.Parse(row["Id"].ToString());
            Doctor.Name = row["Name"].ToString().Trim();
            Doctor.Code = row["Code"].ToString().Trim();
            Doctor.Gender = int.Parse(row["Gender"].ToString());
            return Doctor;
        }
        public Doctor GetByCode(string code)
        {
            string query = "select * from Doctors where Code = @Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.VarChar)
            {
                Value = code
            };

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetDoctorFromDataRow(dt.Rows[0]);
            }
            return null;
        }

        public bool Add(Doctor doctor)
        {
            string query = "INSERT INTO Doctors values(@Name,@Code,@Gender)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = doctor.Name };
            sqlParameters[1] = new SqlParameter("@Code", SqlDbType.NVarChar) { Value = doctor.Code };
            sqlParameters[2] = new SqlParameter("@Gender", SqlDbType.Bit) { Value = doctor.Gender };

            try
            {
                conn.ExecuteInsertQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
