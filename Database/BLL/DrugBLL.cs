using Database.DAO;
using Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BLL
{
    public class DrugBLL
    {
        private readonly DrugDAO _drugDAO;

        public DrugBLL()
        {
            _drugDAO = new DrugDAO();
        }

        public List<Drug> GetAll()
        {
            try
            {
                return _drugDAO.GetDrugs();
            }
            catch (Exception e)
            {
                throw new Exception("Load data of drug is fail");
            }
        }

        public Drug GetById(int id)
        {
            try
            {
                return _drugDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Id is invalid");
            }
        }
        public Drug GetByName(string name)
        {
            try
            {
                return _drugDAO.GetByName(name);

            }
            catch (Exception e)
            {

                throw new Exception("Name is invalid");
            }
        }
        public void Add(Drug drug)
        {
            try
            {
                if(string.IsNullOrEmpty(drug.Name) && string.IsNullOrEmpty(drug.Code) && string.IsNullOrEmpty(drug.Type))
                {
                    throw new Exception("Invalid input");
                }
                _drugDAO.Add(drug);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Drug drug)
        {
            try
            {
                if (string.IsNullOrEmpty(drug.Name) && string.IsNullOrEmpty(drug.Code) && string.IsNullOrEmpty(drug.Type))
                {
                    throw new Exception("Invalid input");
                }
                _drugDAO.Update(drug);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int id)
        {
            
            if (id < 0)
            {
                throw new Exception("Id is invalid");
            }
            if (!_drugDAO.Delete(id))
            {
                throw new Exception("Delete fail");

            }
        }
    }
}
