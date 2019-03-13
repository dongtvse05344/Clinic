using Database.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Prescription : Form
    {
        private Doctor doctor;
        private Database.DTO.Customer customer;
        public Prescription(Doctor _doctor, Database.DTO.Customer _customer)
        {
            InitializeComponent();
            doctor = _doctor;
            customer = _customer;
            lblDoctor.Text += doctor.Name;
            lblCustomer.Text += customer.Name;
        }
    }
}
