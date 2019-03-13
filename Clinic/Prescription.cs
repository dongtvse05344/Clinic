using Database.BLL;
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
        private readonly DrugBLL _drugBLL;
        List<PrescriptionDetail> _prescriptionDetails = new List<PrescriptionDetail>();
        private Doctor doctor;
        private Database.DTO.Customer customer;
        public Prescription(Doctor _doctor, Database.DTO.Customer _customer)
        {
            InitializeComponent();
            doctor = _doctor;
            customer = _customer;
            lblDoctor.Text += doctor.Name;
            lblCustomer.Text += customer.Name;
            _drugBLL = new DrugBLL();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            txtTenThuoc.DataSource = _drugBLL.GetAll();
            txtTenThuoc.DisplayMember = "Name";
            txtTenThuoc.ValueMember = "Id";
            txtAfternoon.Text = "0";
            txtNoon.Text = "0";
        }

        private void btnChon_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            _prescriptionDetails.Add(new PrescriptionDetail
            {
                DrugId = int.Parse(txtTenThuoc.SelectedValue.ToString()),
                Morning = int.Parse(txtMorning.Text.ToString()),
                Afternoon = int.Parse(txtAfternoon.Text.ToString()),
                Noon = int.Parse(txtNoon.Text.ToString()),
                Evening = int.Parse(txtEvening.Text.ToString()),
                IsLunch = cbLunch.Checked
            });
            dgvPrescription.DataSource = _prescriptionDetails;
            dgvPrescription.Columns["Id"].Visible = false;
        }
    }
}
