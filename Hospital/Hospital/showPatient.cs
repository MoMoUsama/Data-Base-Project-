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
    public partial class showPatient : Form
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
        public showPatient()
        {
            InitializeComponent();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            x_RayPatient.Refresh();
            DataTable dt = new DataTable();
            dt = select("select * from patients;");
            x_RayPatient.DataSource = dt;
        }

        private void search_Click(object sender, EventArgs e)
        {
            x_RayPatient.Refresh();
            DataTable dt = new DataTable();
            dt = select("select * from patients p where p.p_id =" + patientID.Text + " ;");
            x_RayPatient.DataSource = dt;
        }

        private void patientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void x_RayPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showPatient_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Close();
            this.Close();
        }
    }
}
