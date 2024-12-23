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
    public partial class AddEmployee : Form
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

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            sql_execute("insert into employees (e_name,e_job,e_birthday,e_salary,c_name) values ('" + name.Text + "' , '" + jop.Text + "','" + birthday.Value.ToString() + "'," + salary.Text + ",'" + clinicName.Text + "')", "Data inserted successfully");
            name.ResetText();
            jop.ResetText();
            salary.ResetText();
            clinicName.ResetText();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clinicName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
