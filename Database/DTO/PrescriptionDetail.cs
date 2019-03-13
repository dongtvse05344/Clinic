using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DTO
{
    public class PrescriptionDetail
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
        public int Morning { get; set; }
        public int Noon { get; set; }
        public int Afternoon { get; set; }
        public int Evening { get; set; }
        public bool IsLunch { get; set; }
        public string ToUse { get; set; }
    }
}
