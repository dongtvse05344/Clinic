using Database.DAO;
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
    public partial class PrescriptionLog : Form
    {
        private Database.DTO.Customer customer;
        private readonly PrescriptionDAO _prescriptionDAO;
        public PrescriptionLog(Database.DTO.Customer _customer)
        {
            InitializeComponent();
            _prescriptionDAO = new PrescriptionDAO();
            customer = _customer;
            lbName.Text += customer.Name;
            lbAddress.Text += customer.Address;
            lbGender.Text += customer.Gender == 0 ? "Nam" : "Nữ";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
