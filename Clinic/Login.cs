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
    public partial class Login : Form
    {
        private readonly DoctorBLL _doctorBLL;
        public Login()
        {
            InitializeComponent();
            _doctorBLL = new DoctorBLL();
            txtCode.Text = "02528";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var doctor = _doctorBLL.GetDoctocByCode(txtCode.Text);
                if (doctor ==null)
                {
                    MessageBox.Show("Code is not existed");
                }
                else
                {
                    //MessageBox.Show("Hello " + doctor.Name);
                    Customer pre = new Customer(doctor);
                    pre.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
