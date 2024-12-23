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
    public partial class InsertPatientToDoctor : Form
    {
        private void sql_execute(string sql_cmd, string message)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FQ85QCL;Initial Catalog=project;Integrated Security=True");
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

        public InsertPatientToDoctor()
        {
            InitializeComponent();
        }

        private void addPatientToDoctor_Click(object sender, EventArgs e)
        {
            sql_execute("update patients set d_id = "+ doctorID.Text+ " where p_id = "+ patientID.Text+ ";", "patient is added to Doctor Successfully");
        }

        private void back_Click(object sender, EventArgs e)
        {
            receptionClinic receptionClinic = new receptionClinic();
            receptionClinic.Show();
            this.Close();
        }
    }
}
