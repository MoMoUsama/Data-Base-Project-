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
using System.IO;

namespace Hospital
{
   

    public partial class Doctor : Form
    {
        static string dbname = "DESKTOP-FQ85QCL";
        public Doctor()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            for (int i = 0; i < 3; i++)
            {
                comboBox4.Items.Add((year+i).ToString());
            }
            for (int i = 0; i < 13; i++)
            {
                comboBox3.Items.Add((i).ToString());
            }
            for (int i = 0; i < 32; i++)
            {
                comboBox2.Items.Add((i).ToString());
            }
        }


        private void saveDiscription()
        {
            File.WriteAllText(".\\discs\\"+ patientId.Text+".txt", description.Text);
        }

        private void saveToXray(bool pharmacy,bool Xray,bool analysis)
        {
            String ConnString = "Data Source = " + dbname + ";Initial Catalog = project;Integrated Security = true";
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            String Query = "SELECT COUNT(p_id) FROM x_rays where p_id = " + patientId.Text;
            SqlCommand cmd = new SqlCommand(Query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if((int)reader.GetValue(0)==0)
            {
                reader.Close();
                Query = " INSERT INTO X_Rays (p_id,date,pharmace,x_ray,test) Values(' " + patientId.Text + "','" + comboBox4.Text + "-" + comboBox3.Text + "-" + comboBox2.Text + "','" + pharmacy.ToString() + "','" + Xray.ToString() + "','" + analysis.ToString() + "')";
            }
            else
            {
                reader.Close();
                Query = " UPDATE X_Rays SET date = '"+ comboBox4.Text + "-" + comboBox3.Text + "-" + comboBox2.Text + "',pharmace = '"+ pharmacy.ToString()+"',x_ray = '" + Xray.ToString() +"',test = '"+ analysis.ToString() + "';";
            }
            SqlCommand cmnd = new SqlCommand(Query, conn);
            cmnd.ExecuteNonQuery();
            Query = "UPDATE patients SET p_file = '" + ".\\discs\\" + patientId.Text + ".txt" + "' WHERE p_id = "+patientId.Text;
            SqlCommand cmnd2 = new SqlCommand(Query, conn);
            cmnd2.ExecuteNonQuery();
            MessageBox.Show("Operation Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox2.Text == "Day") || (comboBox3.Text == "Month") || (comboBox4.Text == "Year"))
            {
                MessageBox.Show("Date Is Not Right");
                return;
            }
            else if (patientId.Text == null)
            {
                MessageBox.Show("patient ID Is Not Right");
                return;
            }
            saveDiscription();
            saveToXray(pharmace.Checked, xRay.Checked, analysis.Checked);
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
