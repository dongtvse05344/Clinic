using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DTO
{
    public class Prescription
    {
        public int Id { get; set; }
        public string DateCreated { get; set; }
        public string Diagnostic { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int DoctorId { get; set; }
    }
}
