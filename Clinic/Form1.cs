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
    public partial class Form1 : Form
    {
        private DrugBLL _drugBLL;
        public Form1()
        {
            InitializeComponent();
            _drugBLL = new DrugBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvManageDrug.DataSource = _drugBLL.GetAll();
            dgvManageDrug.Columns["Id"].Visible = false;
            dgvManageDrug.Columns["Type"].Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            txtID.Clear();
            txtName.Clear();
            txtCode.Clear();
            txtUnitPrice.Clear();
            txtType.Clear();
        }
        private void LoadData()
        {
            dgvManageDrug.DataSource = _drugBLL.GetAll().ToList();
        }

        private void dgvManageDrug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvManageDrug_Click(object sender, EventArgs e)
        {
            int index = dgvManageDrug.CurrentRow.Index;
            if (dgvManageDrug.SelectedRows.Count > 0)
            {
                txtID.Text = dgvManageDrug.SelectedRows[0].Cells["Id"].Value.ToString();
                txtName.Text = dgvManageDrug.SelectedRows[0].Cells["Name"].Value.ToString();
                txtCode.Text = dgvManageDrug.SelectedRows[0].Cells["Code"].Value.ToString();
                txtUnitPrice.Text = dgvManageDrug.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
                txtType.Text = dgvManageDrug.SelectedRows[0].Cells["Type"].Value.ToString();

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string code = txtCode.Text;
            float unitPrice = float.Parse(txtUnitPrice.Text);
            string type = txtType.Text;
            try
            {
                _drugBLL.Add(new Drug
                {
                    Name = name,
                    Code = code,
                    UnitPrice = unitPrice,
                    Type = type
                });
                MessageBox.Show("Insert successful!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string code = txtCode.Text;
                float unitPrice = float.Parse(txtUnitPrice.Text);
                string type = txtType.Text;
                var drug = new Drug
                {
                    Id = id,
                    Name = name,
                    Code = code,
                    UnitPrice = unitPrice,
                    Type = type
                };
                _drugBLL.Update(drug);
                MessageBox.Show("Update successful!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                dgvManageDrug.DataSource = _drugBLL.GetByName(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txtID.Text);
                _drugBLL.Delete(id);
                MessageBox.Show("Delete Sucess");
                LoadData();
                txtID.Clear();
                txtName.Clear();
                txtCode.Clear();
                txtUnitPrice.Clear();
                txtType.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
