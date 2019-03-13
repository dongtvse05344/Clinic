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
            try
            {
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
    }
}
