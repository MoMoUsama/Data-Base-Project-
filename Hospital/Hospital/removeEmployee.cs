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
    public partial class removeEmployee : Form
    {
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
        public removeEmployee()
        {
            InitializeComponent();
        }

        private void removeEmp_Click(object sender, EventArgs e)
        {
            sql_execute("delete from employees where e_id = " + Emp_ID.Text + ";", "Employee is Deleted successfully");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();   
        }
    }
}
