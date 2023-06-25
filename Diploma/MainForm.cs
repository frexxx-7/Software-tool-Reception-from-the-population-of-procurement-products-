using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diploma.DataBase;
using Diploma.Forms;
using Diploma.Forms.Forms;
using MySql.Data.MySqlClient;

namespace Diploma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void сдатчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeliveryForm().Show();
            this.Hide();
        }

        private void сырьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RawForm().Show();
            this.Hide();
        }

        private void заготовительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClickerForm().Show();
            this.Hide();
        }

        private void приемнаяКвитанцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
            this.Hide();
        }
    }
}
