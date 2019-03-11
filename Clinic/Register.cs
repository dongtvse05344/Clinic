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
    public partial class Register : Form
    {
        private DoctorBLL _doctorBLL;
        public Register()
        {
            InitializeComponent();
            rdnMale.Checked = true;
            _doctorBLL = new DoctorBLL();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor doctor = new Doctor
                {
                    Name = txtName.Text,
                };
                if (rdnFemale.Checked) { doctor.Gender = 0; } else { doctor.Gender = 1; }
                string code = _doctorBLL.CreateDoctor(doctor);
                MessageBox.Show("Your code is : " + code + " \n Please remember this");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
