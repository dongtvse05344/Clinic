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
        private Doctor currentDoctor;
        public Prescription()
        {
            InitializeComponent();
        }
        public Prescription(Doctor doctor)
        {
            InitializeComponent();
            currentDoctor = doctor;
            label1.Text += currentDoctor.Name;
        }
        private void Prescription_Load(object sender, EventArgs e)
        {

        }
    }
}
