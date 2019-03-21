﻿using Database.BLL;
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
        private readonly PrescriptionBLL _presctiptionBBL = new PrescriptionBLL();
        private Doctor doctor;
        private Database.DTO.Customer customer;
        private Database.DTO.Prescription prescription = new Database.DTO.Prescription();
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
            try
            {
                //validate
                _prescriptionDetails.Add(new PrescriptionDetail
                {
                    DrugId = int.Parse(txtTenThuoc.SelectedValue.ToString()),
                    DrugName = ((Drug)txtTenThuoc.SelectedItem).Name.ToString(),
                    Morning = int.Parse(txtMorning.Text.ToString()),
                    Afternoon = int.Parse(txtAfternoon.Text.ToString()),
                    Noon = int.Parse(txtNoon.Text.ToString()),
                    Evening = int.Parse(txtEvening.Text.ToString()),
                    IsLunch = cbLunch.Checked,
                    Quantity = int.Parse(txtSoLuong.Text.ToString()),
                    ToUse = txtToUse.Text
                });
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadData()
        {
            dgvPrescription.DataSource = _prescriptionDetails.ToList();
            dgvPrescription.Columns["Id"].Visible = false;
            dgvPrescription.Columns["PrescriptionId"].Visible = false;
            dgvPrescription.Columns["DrugId"].Visible = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            prescription.CustomerId = this.customer.Id;
            prescription.DoctorId = this.doctor.Id;
            prescription.Diagnostic = txtDiagnostic.Text;
            prescription.Description = txtDescription.Text;
            prescription.Details = this._prescriptionDetails;
            try
            {
                _presctiptionBBL.Create(prescription);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvPrescription.CurrentRow.Index;
            this._prescriptionDetails.RemoveAt(index);
            LoadData();
        }

        private void keDonThuoc_Click(object sender, EventArgs e)
        {
            PrescriptionLog log = new PrescriptionLog(this.doctor,this.customer);
            log.Show();
            this.Hide();
        }
    }
}
