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
    public partial class Show_xReay_Patient : Form
    {
        public Show_xReay_Patient()
        {
            InitializeComponent();
        }
        
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
        private void search_Click(object sender, EventArgs e)
        {
            x_RayPatient.Refresh();
            DataTable dataTable = new DataTable();
            dataTable = select("select * from patients p, X_rays x where x.p_id ="+patientID.Text+" and p.p_id = "+patientID.Text+";");
            x_RayPatient.DataSource = dataTable;
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            x_RayPatient.Refresh();
            DataTable dataTable = new DataTable();
            dataTable = select("select * from patients p, X_rays x where p.p_id = x.p_id;");
            x_RayPatient.DataSource = dataTable;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Close();
            this.Close();
        }
    }
}
