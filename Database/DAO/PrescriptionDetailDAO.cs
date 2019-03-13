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
    public class PrescriptionDetailDAO
    {
        private readonly DBConnection conn;
        public PrescriptionDetailDAO()
        {
            conn = new DBConnection();
        }
        private PrescriptionDetail GetPrescriptionDetailFromDataRow(DataRow row)
        {
            PrescriptionDetail prescriptionDetail = new PrescriptionDetail();
            prescriptionDetail.Id = int.Parse(row["Id"].ToString());
            prescriptionDetail.IsLunch = bool.Parse(row["Id"].ToString());
            prescriptionDetail.Morning = int.Parse(row["Id"].ToString());
            prescriptionDetail.Noon = int.Parse(row["Id"].ToString());
            prescriptionDetail.PrescriptionId = int.Parse(row["Id"].ToString());
            prescriptionDetail.Quantity = int.Parse(row["Id"].ToString());
            prescriptionDetail.ToUse = row["Id"].ToString();
            prescriptionDetail.Afternoon = int.Parse(row["Id"].ToString());
            prescriptionDetail.DrugId = int.Parse(row["Id"].ToString());
            prescriptionDetail.Evening = int.Parse(row["Id"].ToString());
            return prescriptionDetail;
        }
        public bool Add(PrescriptionDetail model)
        {
            string query = "INSERT INTO PrescriptionDetail " +
                "values(@PrescriptionId,@DrugId,@Quantity,@Morning,@Noon,@Afternoon,@Evening,@IsLunch,@ToUse)";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@PrescriptionId", SqlDbType.Int) { Value = model.PrescriptionId };
            sqlParameters[1] = new SqlParameter("@DrugId", SqlDbType.Int) { Value = model.DrugId };
            sqlParameters[2] = new SqlParameter("@Quantity", SqlDbType.Int) { Value = model.Quantity };
            sqlParameters[3] = new SqlParameter("@Morning", SqlDbType.Int) { Value = model.Morning };
            sqlParameters[4] = new SqlParameter("@Noon", SqlDbType.Int) { Value = model.Noon };
            sqlParameters[5] = new SqlParameter("@Afternoon", SqlDbType.Int) { Value = model.Afternoon };
            sqlParameters[6] = new SqlParameter("@Evening", SqlDbType.Int) { Value = model.Evening };
            sqlParameters[7] = new SqlParameter("@IsLunch", SqlDbType.Bit) { Value = model.IsLunch };
            sqlParameters[8] = new SqlParameter("@ToUse", SqlDbType.NVarChar) { Value = model.ToUse };

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
