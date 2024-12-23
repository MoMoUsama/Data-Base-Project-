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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class insertNewPatient : Form
    {
       // string c = @"Server=DESKTOP-1O052OR;Database=project;Trusted_Connection=True;";

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

        public insertNewPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertNewPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-RETO5T3;Database=ta;Trusted_Connection=True;");
            string c = @"Server=DESKTOP-RETO5T3;Database=project;Trusted_Connection=True;";
            using (conn)
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * FROM assistants", conn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.Visible = true;
            }
            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server =DESKTOP-1O052OR; database = project ;integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();


            cmd.CommandText = "INSERT INTO patients (p_name, p_age, clinc_name, p_date) VALUES ('" + name1.Text + "', '" + age.Text + "', '" + clinc.Text + "', '" + dateTimePicker1.Text + "'); INSERT INTO patient_phones VALUES (" + phone.Text + ", (SELECT MAX(p_id) FROM patients))";


            int rowsAffected = cmd.ExecuteNonQuery();

            // Do something based on the number of affected rows
            if (rowsAffected > 0)
            {
                Console.WriteLine("Data inserted successfully.");
            }
            else
            {
                Console.WriteLine("No data inserted.");
            }

            con.Close();*/
            sql_execute("INSERT INTO patients (p_name, p_age, clinc_name, p_date) VALUES ('" + name1.Text +"', '" + age.Text + "', '" + clinc.Text + "', '" + dateTimePicker1.Value.ToString()+"'); INSERT INTO patient_phones VALUES ("+ phone.Text +", (SELECT MAX(p_id) FROM patients))", "patient inserted successfully");

        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void clinc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            mainReception mainReception = new mainReception();
            mainReception.Show();
            this.Close();
        }
    }
}
