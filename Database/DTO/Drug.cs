using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DTO
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string UnitPrice { get; set; }
        public string Type { get; set; }
    }
}
