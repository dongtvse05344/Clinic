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
        public PrescriptionLog(Database.DTO.Doctor _doctor,Database.DTO.Customer _customer)
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
            if (dgvPrescriptionLog.SelectedRows.Count > 0)
            {
                var id = int.Parse(dgvPrescriptionLog.SelectedRows[0].Cells["Id"].Value.ToString());
                PrescriptionLogDetail detail = new PrescriptionLogDetail(id);
                detail.ShowDialog();
            }
        }

        private void PrescriptionLog_Load(object sender, EventArgs e)
        {

        }
    }
}
