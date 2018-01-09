using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_UAS
{
    public partial class MainForm : Form
    {
        public Boolean loginStatus = false;

        public MainForm()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            loginToolStripMenuItem.Enabled = !loginStatus;
            logoutToolStripMenuItem.Enabled = loginStatus;
            masterDataToolStripMenuItem.Enabled = loginStatus;
            transaksiToolStripMenuItem.Enabled = loginStatus;
            laporanToolStripMenuItem.Enabled = loginStatus;
            treeView.Enabled = loginStatus;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            loginStatus = login.login;
            Setup();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginStatus = false;
            Setup();
        }
    }
}
