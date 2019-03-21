using Database.BLL;
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
        private Database.DTO.Doctor doctor;
        private readonly PrescriptionBLL _prescriptionBLL;
        public PrescriptionLog(Database.DTO.Doctor _doctor, Database.DTO.Customer _customer)
        {
            InitializeComponent();
            _prescriptionBLL = new PrescriptionBLL();
            customer = _customer;
            doctor = _doctor;
            lbName.Text += customer.Name;
            lbAddress.Text += customer.Address;
            lbGender.Text += customer.Gender == 0 ? "Nam" : "Nữ";
            lbTel.Text += customer.Phone;
            lbAge.Text += customer.BirthDate;
            LoadData();
        }

        private void LoadData()
        {
            dgvPrescriptionLog.DataSource = _prescriptionBLL.GetPrescriptionsByCustomer(customer.Id);
            dgvPrescriptionLog.Columns["Id"].Visible = false;
            dgvPrescriptionLog.Columns["CustomerId"].Visible = false;
            dgvPrescriptionLog.Columns["DoctorId"].Visible = false;

        }

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrescriptionLog.SelectedRows.Count > 0)
                {
                    var id = int.Parse(dgvPrescriptionLog.SelectedRows[0].Cells["Id"].Value.ToString());
                    PrescriptionLogDetail detail = new PrescriptionLogDetail(id);
                    detail.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PrescriptionLog_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tạoĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription(this.doctor, this.customer);
            prescription.Show();
            this.Hide();
        }

        private void quảnLíKhoThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugManage drugManage = new DrugManage(this.doctor);
            drugManage.Show();
            this.Hide();
        }

        private void kháchHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer Formcustomer = new Customer(this.doctor);
            Formcustomer.Show();
            this.Hide();
        }
    }
}
