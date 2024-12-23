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
    public partial class receptionClinic : Form
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

        public receptionClinic()
        {
            InitializeComponent();
        }

        private void clinicRoom_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = select("select * from patients where (d_id is null) and (clinc_name = '" + clinicName.Text + "');");
            showResult.DataSource = dt;

        }

        private void hospitalRoom_Click(object sender, EventArgs e)
        {
            InsertPatientToDoctor insertPatientToDoctor = new InsertPatientToDoctor();
            insertPatientToDoctor.Show();
            this.Close();
        }

        private void orderPatients_Click(object sender, EventArgs e)
        {
            OrderOfClinic orderOfClinic = new OrderOfClinic();
            orderOfClinic.Show();
            this.Close();
        }

        private void showClinicPatient_Click(object sender, EventArgs e)
        {
            PatientAtThisDate patientAtThisDate = new PatientAtThisDate();
            patientAtThisDate.Show();
            this.Close();
        }

        private void removeFromClinic_Click(object sender, EventArgs e)
        {
            RemovePatientFromClinic removePatientFromClinic = new RemovePatientFromClinic();
            removePatientFromClinic.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            wellcome wellcome = new wellcome();
            wellcome.Show();
            this.Close();
        }
    }
}
