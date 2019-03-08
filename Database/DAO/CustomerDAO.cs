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
    public class CustomerDAO
    {
        private DBConnection conn;
        public CustomerDAO()
        {
            conn = new DBConnection();
        }
        private Customer GetCustomerFromDataRow(DataRow row)
        {
            Customer Customer = new Customer();

            Customer.Id = int.Parse(row["Id"].ToString());
            Customer.Name = row["Name"].ToString().Trim();
            Customer.Address = row["Address"].ToString().Trim();
            Customer.Phone = row["Phone"].ToString().Trim();
            Customer.BirthDate = row["BirthDate"].ToString().Trim();
            Customer.Gender = int.Parse(row["Gender"].ToString());
            return Customer;
        }

        public Customer GetByPhone(string phone)
        {
            string query = "select * from Customers where Phone = @Phone";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Phone", SqlDbType.VarChar) {
                Value = phone
            };

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetCustomerFromDataRow(dt.Rows[0]);
            }
            return null;
        }
        public bool Add(Customer Customer)
        {
            string query = "INSERT INTO Customers values(@Name,@Address,@Phone,@BirthDate,@Gender)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = Customer.Name };
            sqlParameters[1] = new SqlParameter("@Address", SqlDbType.NVarChar) { Value = Customer.Address };
            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = Customer.Phone };
            sqlParameters[3] = new SqlParameter("@BirthDate", SqlDbType.NVarChar) { Value = Customer.BirthDate };
            sqlParameters[4] = new SqlParameter("@Gender", SqlDbType.NVarChar) { Value = Customer.Gender };

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

        public bool Update(Customer Customer)
        {
            string query = "UPDATE Customers SET Name=@Name, Address=@Address, Phone=@Phone, BirthDate=@BirthDate,Gender=@Gender," +
                " WHERE Id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = Customer.Name };
            sqlParameters[1] = new SqlParameter("@Address", SqlDbType.NVarChar) { Value = Customer.Address };
            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = Customer.Phone };
            sqlParameters[3] = new SqlParameter("@BirthDate", SqlDbType.NVarChar) { Value = Customer.BirthDate };
            sqlParameters[4] = new SqlParameter("@Gender", SqlDbType.NVarChar) { Value = Customer.Gender };
            sqlParameters[5] = new SqlParameter("@Id", SqlDbType.NVarChar) { Value = Customer.Id };

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
