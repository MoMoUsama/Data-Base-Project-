using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            addEmp.Show();
            this.Close();
        }

        private void addDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor addDoc = new AddDoctor();
            addDoc.Show();
            this.Close();
        }

        private void patientXRay_Click(object sender, EventArgs e)
        {
            Show_xReay_Patient show_XReay_Patient = new Show_xReay_Patient();
            show_XReay_Patient.Show();
            this.Close();
        }

        private void showPatient_Click(object sender, EventArgs e)
        {
            showPatient p = new showPatient();
            p.Show();
            this.Close();
        }

        private void removeEmployee_Click(object sender, EventArgs e)
        {
            removeEmployee employee = new removeEmployee();
            employee.Show();
            this.Close();
        }

        private void removeDoctor_Click(object sender, EventArgs e)
        {
            RemoveDoctore removeDoctore = new RemoveDoctore();
            removeDoctore.Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            wellcome wellcome = new wellcome();
            wellcome.Show();
            this.Close();
        }
    }
}
