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
    public partial class RemovePatientFromClinic : Form
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

        public RemovePatientFromClinic()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void removepatient_Click(object sender, EventArgs e)
        {
            sql_execute("delete from orders where p_id = "+patientId.Text+";", "patient is deleted from clinic successfully");

            sql_execute("insert into X_rays (p_id) values(" + patientId.Text + ");", "patient is inserted to x_ray");

            if (Parmacy.Checked)
            {
                sql_execute("update X_rays set pharmace = 'yes' where p_id ="+patientId.Text+" ;", "patient is inserted to pharmacy");
            }
            if(xray.Checked)
            {
                sql_execute("update X_rays set x_ray = 'yes' where p_id =" + patientId.Text + " ;", "patient is inserted to x_ray");
            }
            if (test.Checked)
            {
                sql_execute("update X_rays set test = 'yes' where p_id =" + patientId.Text + " ;", "patient is inserted to test");
            }
        }

        private void RemovePatientFromClinic_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            receptionClinic receptionClinic = new receptionClinic();
            receptionClinic.Show();
            this.Close();
        }
    }
}
