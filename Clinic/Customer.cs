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
    public partial class Customer : Form
    {
        private Doctor currentDoctor;
        private CustomerBLL _customerBLL;
        
        public Customer(Doctor doctor)
        {
            InitializeComponent();
            currentDoctor = doctor;
            _customerBLL = new CustomerBLL();
            label1.Text += currentDoctor.Name;
            txtBirthDate.Format = DateTimePickerFormat.Custom;
            txtBirthDate.CustomFormat = "yyyy-MM-dd";
            rbFemale.Checked = true;
        }
        private void Prescription_Load(object sender, EventArgs e)
        {
            txtPhone.Text = "012341234";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetByPhone_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            var customer  = _customerBLL.GetByPhone(phone);
            if (customer ==null)
            {
                MessageBox.Show("Vui lòng điền thông tin khách hàng.");
            }
            else
            {
                txtId.Text = customer.Id.ToString();
                txtName.Text = customer.Name; 
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
                txtBirthDate.Text = customer.BirthDate;
                if(customer.Gender ==0)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Database.DTO.Customer customer = new Database.DTO.Customer {
                   
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    BirthDate = txtBirthDate.Text,
                };
                int id = -1;
                try
                {
                    id = int.Parse(txtId.Text);
                }
                catch (Exception)
                {
                }
                customer.Id = id;
                if (rbFemale.Checked) { customer.Gender = 1; } else { customer.Gender = 0; }

                _customerBLL.AddOrUpdate(customer);
                MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                Prescription pre = new Prescription(this.currentDoctor, customer) ;
                pre.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void managermentDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugManage drugs = new DrugManage();
            drugs.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
