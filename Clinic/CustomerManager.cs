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
    public partial class CustomerManager : Form
    {
        private Database.DTO.Doctor Doctor;
        private Database.BLL.CustomerBLL _customerBLL;
        public CustomerManager(Database.DTO.Doctor _Doctor)
        {
            InitializeComponent();
            Doctor = _Doctor;
            lbDoctor.Text += Doctor.Name;
            _customerBLL = new Database.BLL.CustomerBLL();
        }

        private void CustomerManager_Load(object sender, EventArgs e)
        {
        }

        private void LoadData()
        {
            dgvCustomer.DataSource = _customerBLL.GetCustomers();
            dgvCustomer.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(this.Doctor);
            customer.Show();
            this.Hide();
        }
    }
}
