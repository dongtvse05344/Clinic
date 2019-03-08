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
            if(dgvManageDrug.SelectedRows.Count > 0)
            {
                int id = (int)dgvManageDrug.SelectedRows[0].Cells[0].Value;
                var drug = _drugBLL.GetById(id);
                if(drug != null)
                {
                    txtID.Text = drug.Id.ToString();
                    txtName.Text = drug.Name.ToString();
                    txtCode.Text = drug.Code.ToString();
                    txtUnitPrice.Text = drug.UnitPrice.ToString();
                    txtType.Text = drug.Type.ToString();
                }
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
                float unitPrice = float.Parse( txtUnitPrice.Text);
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
                Drug drug = _drugBLL.GetByName(txtName.Text);
                if (drug == null)
                {
                    MessageBox.Show("Not Found 404");
                }
                else
                {
                    txtID.Text = drug.Id.ToString();
                    txtName.Text = drug.Name;
                    txtCode.Text = drug.Code;
                    txtUnitPrice.Text = drug.UnitPrice.ToString();
                    txtType.Text = drug.Type;
                }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
