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
    public partial class searchPatient : Form
    {
        public searchPatient()
        {
            InitializeComponent();
        }

        private void searchPatient_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FQ85QCL;Initial Catalog=project;Integrated Security=True");
           
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM patients WHERE p_id = @PatientId", conn);
                cmd.Parameters.AddWithValue("@PatientId", textBox1.Text);
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.Visible = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainReception mainReception = new mainReception();
            mainReception.Show();
            this.Close();
        }
    }
}
