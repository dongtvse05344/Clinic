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
            LoadData();
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

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomer.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dgvCustomer.SelectedRows[0].Cells["Id"].Value.ToString()); ;
                    var customer = _customerBLL.GetCustomer(id);
                    PrescriptionLog customerForm = new PrescriptionLog(this.Doctor, customer);
                    customerForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void khoThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugManage drug = new DrugManage(this.Doctor);
            drug.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCustomer.DataSource = _customerBLL.GetCustomers(txtNameSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
