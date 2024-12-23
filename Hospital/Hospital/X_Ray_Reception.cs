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
    public partial class X_Ray_Reception : Form
    {
        public DataTable select(string selectStatment)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1O052OR;Initial Catalog=project;Integrated Security=True");
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

        private void sql_execute(string sql_cmd, string message)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Ahmed-Ali;Initial Catalog=project;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql_cmd;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(message);
                conn.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(text: ex.Message);
            }
        }


        public X_Ray_Reception()
        {
            InitializeComponent();
        }

        private void showPatientInXRay_Click(object sender, EventArgs e)
        {
            patientINXray.Refresh();
            DataTable dataTable = new DataTable();
            dataTable = select("select * from X_rays;");
            patientINXray.DataSource = dataTable;
        }

        private void addToXRay_Click(object sender, EventArgs e)
        {
            sql_execute("update X_rays set timeOfinsertion = '" + timeOfInsertion.Text + "' where p_id = " + patientID.Text + ";", "patient is added to x_ray");
        }

        private void X_Ray_Reception_Load(object sender, EventArgs e)
        {

        }
    }
}
