using Database.BLL;
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
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
                    txtName.Text = drug.Name.ToString();
                    txtCode.Text = drug.Code.ToString();
                    txtUnitPrice.Text = drug.UnitPrice.ToString();
                }
            }
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string code = txtCode.Text;
            float unitPrice = float.Parse(txtUnitPrice.Text);
            string type = txtType.Text;

        }
    }
}
