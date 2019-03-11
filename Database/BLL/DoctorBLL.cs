using Database.DAO;
using Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BLL
{
    public class DoctorBLL
    {
        private readonly DoctorDAO _doctorDAO;
        public DoctorBLL()
        {
            _doctorDAO = new DoctorDAO();
        }

        public Doctor GetDoctocByCode(string code)
        {
            try
            {
                var doctor = _doctorDAO.GetByCode(code);
                if (doctor == null)
                {
                    throw new Exception("Code is not existed");
                }
                return doctor;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string CreateDoctor(Doctor doctor)
        {
            if (string.IsNullOrEmpty(doctor.Name))
            {
                throw new Exception("Name can not be blank");
            }
            if(doctor.Gender != 0 && doctor.Gender != 1)
            {
                throw new Exception("Please choose your gender");
            }
            try
            {
                do
                {
                    string code = new Random().Next(1, 99999).ToString("00000");
                    if (_doctorDAO.GetByCode(code) == null)
                    {
                        doctor.Code = code;
                        _doctorDAO.Add(doctor);
                        return code;
                    }
                } while (true);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
