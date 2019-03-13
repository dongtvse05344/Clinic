using Database.Connection;
using Database.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DAO
{
    public class PrescriptionDAO
    {
        private readonly DBConnection conn;
        public PrescriptionDAO()
        {
            conn = new DBConnection();
        }

        private Prescription GetPrescriptionFromDataRow(DataRow row)
        {
            Prescription Prescription = new Prescription();

            Prescription.Id = int.Parse(row["Id"].ToString());
            Prescription.CustomerId = int.Parse(row["CustomerId"].ToString());
            Prescription.DateCreated = row["DateCreated"].ToString().Trim();
            Prescription.Description = row["Description"].ToString();
            Prescription.Diagnostic = row["Diagnostic"].ToString();
            Prescription.DoctorId = int.Parse(row["DoctorId"].ToString());
            return Prescription;
        }

        public int Add( Prescription  Prescription)
        {
            string query = "INSERT INTO Prescriptions " +
                "OUTPUT Inserted.ID " +
                "values(@DateCreated,@Diagnostic,@Description,@CustomerId,@DoctorId)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@DateCreated", SqlDbType.DateTime) { Value =  Prescription.DateCreated };
            sqlParameters[1] = new SqlParameter("@Diagnostic", SqlDbType.NVarChar) { Value =  Prescription.Diagnostic };
            sqlParameters[2] = new SqlParameter("@Description", SqlDbType.Bit) { Value =  Prescription.Description };
            sqlParameters[3] = new SqlParameter("@CustomerId", SqlDbType.Int) { Value =  Prescription.CustomerId };
            sqlParameters[4] = new SqlParameter("@DoctorId", SqlDbType.Int) { Value =  Prescription.DoctorId };

            try
            {
                DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
                if(dt.Rows.Count>0)
                {
                    return int.Parse(dt.Rows[0]["ID"].ToString());
                }
                return -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Prescription> GetPrescriptionsByCustomer(int customerId)
        {
            string query = "select * from Prescriptions where CustomerId = @CustomerId ORDER BY DateCreated DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@CustomerId", SqlDbType.Int)
            {
                Value = customerId
            };
            List<Prescription> result = new List<Prescription>();
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            while (dt.Rows.Count > 0)
            {
                result.Add(GetPrescriptionFromDataRow(dt.Rows[0]));
            }
            return result;
        }
    }
}
