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
    public partial class wellcome : Form
    {
        

        public wellcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.Show();
        
        }

        private void mainReception_Click(object sender, EventArgs e)
        {
            mainReception mainRece = new mainReception();
            mainRece.Show();
            
        }

        private void clinicReception_Click(object sender, EventArgs e)
        {
            receptionClinic clinicreception = new receptionClinic();
            clinicreception.Show();
            
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();  
            admin.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X_Ray_Reception x_Ray_Reception = new X_Ray_Reception();
            x_Ray_Reception.Show();
            
        }
    }
}
