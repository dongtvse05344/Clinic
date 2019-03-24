using Database.DAO;
using Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BLL
{
    public class PrescriptionBLL
    {
        private readonly PrescriptionDAO _prescriptionDAO;
        private readonly PrescriptionDetailDAO _detailDAO;
        public PrescriptionBLL()
        {
            _prescriptionDAO = new PrescriptionDAO();
            _detailDAO = new PrescriptionDetailDAO();
        }

        public void Create(Prescription prescription)
        {
            if (string.IsNullOrEmpty(prescription.Description)
               || string.IsNullOrEmpty(prescription.Diagnostic)
               || prescription.Details.Count == 0
                )
            {
                throw new Exception("Input is not valid");
            }
            try
            {
                prescription.DateCreated = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                int prescriptioId = _prescriptionDAO.Add(prescription);
                foreach (var item in prescription.Details)
                {
                    item.PrescriptionId = prescriptioId;
                    _detailDAO.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Prescription> GetPrescriptionsByCustomer(int customerId)
        {
            return _prescriptionDAO.GetPrescriptionsByCustomer(customerId);
        }
        public Prescription GetPrescription(int id)
        {
            Prescription result = _prescriptionDAO.GetPrescription(id);
            result.Details = _detailDAO.GetPrescriptionDetails(id);
            return result;
        }
    }
}
