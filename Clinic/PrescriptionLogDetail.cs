﻿using System;
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
    public partial class PrescriptionLogDetail : Form
    {
        private readonly Database.DTO.Prescription prescription;
        private readonly Database.BLL.PrescriptionBLL _prescriptionBLL;
        private readonly Database.BLL.DrugBLL _drugBLL;
        private readonly Database.BLL.DoctorBLL _doctorBLL;
        private readonly float amount = 0;
        private readonly Database.DTO.Doctor doctor;
        public PrescriptionLogDetail(int id)
        {
            InitializeComponent();
            _prescriptionBLL = new Database.BLL.PrescriptionBLL();
            _drugBLL = new Database.BLL.DrugBLL();
            _doctorBLL = new Database.BLL.DoctorBLL();
            this.prescription = _prescriptionBLL.GetPrescription(id);
            foreach (var item in prescription.Details)
            {
                var drug = _drugBLL.GetById(item.DrugId);
                item.DrugName = drug.Name;
                amount += drug.UnitPrice * item.Quantity;
            }
            lbAmount.Text += amount + " $";
            doctor = _doctorBLL.GetDoctocById(prescription.DoctorId);
            lbdoctor.Text += " " + doctor.Name;
        }

        private void PrescriptionLogDetail_Load(object sender, EventArgs e)
        {
            try
            {
                lbChuanDoan.Text = prescription.Diagnostic;
                lbGhiChu.Text = prescription.Description;
                dgvPrescriptionLogDetail.DataSource = prescription.Details;
                dgvPrescriptionLogDetail.Columns["Id"].Visible = false;
                dgvPrescriptionLogDetail.Columns["PrescriptionId"].Visible = false;
                dgvPrescriptionLogDetail.Columns["DrugId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
