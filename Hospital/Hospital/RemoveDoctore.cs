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
    public partial class RemoveDoctore : Form
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
        public RemoveDoctore()
        {
            InitializeComponent();
        }

        private void removeDoc_Click(object sender, EventArgs e)
        {
            sql_execute("delete from Doctors where d_id = " + doc_ID.Text + ";", "Employee is Deleted successfully");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
