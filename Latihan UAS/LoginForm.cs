using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Latihan_UAS
{
    public partial class LoginForm : Form
    {
        public Boolean login = false;
        private string sql;
        private SqlDataReader rd;
        private SqlCommand cmd;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 || txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Username dan Password masih kosong.");
                return;
            }
            Connection.Open();
            sql = "SELECT * FROM tb_user WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
            cmd = new SqlCommand(sql, Connection.Connect);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                login = true;
                Dispose();
            }else
            {
                MessageBox.Show("Username atau Password tidak ditemukan.");
            }

            rd.Close();
            Connection.Close();

        }
    }
}
