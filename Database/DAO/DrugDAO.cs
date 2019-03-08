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
    public class DrugDAO
    {
        private DBConnection conn;
        public DrugDAO()
        {
            conn = new DBConnection();
        }
        private Drug GetDrugFromDataRow(DataRow row)
        {
            Drug drug = new Drug();

            drug.Id = int.Parse(row["Id"].ToString());
            drug.Name = row["Name"].ToString().Trim();
            drug.Code = row["Code"].ToString().Trim();
            drug.UnitPrice = float.Parse(row["UnitPrice"].ToString());
            drug.Type = row["Type"].ToString().Trim();
            return drug;
        }


        public List<Drug> GetDrugs()
        {
            string query = string.Format("select * from Drugs WHERE IsActive = 'true'");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<Drug> list = new List<Drug>();

            foreach (DataRow r in dt.Rows)
            {
                Drug drug = GetDrugFromDataRow(r);
                list.Add(drug);
            }
            return list;
        }

        public Drug GetById(int _id)
        {
            string query = "select * from Drugs where Id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            sqlParameters[0].Value = _id;

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetDrugFromDataRow(dt.Rows[0]);
            }
            return null;
        }
        public Drug GetByName(string _name)
        {
            string query = "Select *From Drugs where Name = @Name  and IsActive = 'true'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[0].Value = _name;
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if(dt.Rows.Count >0)
            {
                return GetDrugFromDataRow(dt.Rows[0]);
            }
            return null;
        }
        public bool Add(Drug drug)
        {
            string query = "INSERT INTO Drugs values(@Name,@Code,@UnitPrice,@Type,'true')";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = drug.Name };
            sqlParameters[1] = new SqlParameter("@Code", SqlDbType.NVarChar) { Value = drug.Code };
            sqlParameters[2] = new SqlParameter("@UnitPrice", SqlDbType.Float) { Value = drug.UnitPrice };
            sqlParameters[3] = new SqlParameter("@Type", SqlDbType.NVarChar) { Value = drug.Type };

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

        public bool Update(Drug drug)
        {
            string query = "UPDATE Drugs SET Name=@Name, Code=@Code, UnitPrice=@UnitPrice, Type=@Type WHERE Id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = drug.Name };
            sqlParameters[1] = new SqlParameter("@Code", SqlDbType.NVarChar) { Value = drug.Code };
            sqlParameters[2] = new SqlParameter("@UnitPrice", SqlDbType.Float) { Value = drug.UnitPrice };
            sqlParameters[3] = new SqlParameter("@Type", SqlDbType.NVarChar) { Value = drug.Type };
            sqlParameters[4] = new SqlParameter("@Id", SqlDbType.NVarChar) { Value = drug.Id };

            try
            {
                conn.ExecuteUpdateQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            string query = "Update Drugs SET IsActive=@IsActive WHERE id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int) { Value = id };
            sqlParameters[0] = new SqlParameter("@IsActive", SqlDbType.Bit) { Value = false };

            try
            {
                conn.ExecuteUpdateQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
