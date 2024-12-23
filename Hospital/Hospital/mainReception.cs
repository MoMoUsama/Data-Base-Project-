using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class mainReception : Form
    {
        public mainReception()
        {
            InitializeComponent();
        }

        private void insertPatient_Click(object sender, EventArgs e)
        {
            insertNewPatient patient = new insertNewPatient();
            patient.Show();
            this.Close();
        }

        private void ssearchPatient_Click(object sender, EventArgs e)
        {
            searchPatient searchPatient = new searchPatient();
            searchPatient.Show();


            {

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            wellcome wellcome = new wellcome();
            wellcome.Show();
            this.Close();
        }
    }
}
