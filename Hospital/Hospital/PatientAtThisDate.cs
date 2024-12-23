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
    public partial class PatientAtThisDate : Form
    {
        public DataTable select(string selectStatment)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FQ85QCL;Initial Catalog=project;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectStatment;
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(text: ex.Message);
            }
            return dt;
        }
        public PatientAtThisDate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orderpatient_Click(object sender, EventArgs e)
        {
            patientInThisDate.Refresh();
            DataTable dt = new DataTable();
            dt = select("select * from patients p where p.clinc_name = '"+ clinicName.Text+ "' and p.p_date = '"+ date.Value.ToString()+ "';");
            patientInThisDate.DataSource = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {
            receptionClinic receptionClinic = new receptionClinic();
            receptionClinic.Show();
            this.Close();   
        }
    }
}
