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
    public partial class AddDoctor : Form
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

        public AddDoctor()
        {
            InitializeComponent();
        }

        private void addDoc_Click(object sender, EventArgs e)
        {
            
            sql_execute("insert into Doctors (d_name,room_id,birthdate,salary,specialty) values ('" + name.Text + "'," + roomID.Text + ",'" + birthday.Value.ToString() + "'," + salary.Text + ",'" + specialty.Text + "'); ", "Data inserted successfuly");
            name.ResetText();
            roomID.ResetText(); 
            salary.ResetText();
            specialty.ResetText();
        }

        private void specialty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
           this.Close();
        }
    }
}
