using Diploma.DataBase;
using Diploma.Forms.AddForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma.Forms
{
    public partial class ClickerForm : Form
    {
        public ClickerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddClicker(ClickerDataGrid[0, ClickerDataGrid.SelectedCells[0].RowIndex].Value.ToString(), ClickerDataGrid[4, ClickerDataGrid.SelectedCells[0].RowIndex].Value.ToString(), ClickerDataGrid[7, ClickerDataGrid.SelectedCells[0].RowIndex].Value.ToString()).Show();
        }
        private void loadInfoClicker()
        {
            DB db = new DB();
            ClickerDataGrid.Rows.Clear();

            string query = "select * from clicker " +
                "inner join raysoyuz " +
                "on clicker.idRaysouyz = raysoyuz.id " +
                "inner join region " +
                "on raysoyuz.idRegion = region.id";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    ClickerDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void AddClickerButton_Click(object sender, EventArgs e)
        {
            new AddClicker(null, null, null).Show();
        }

        private void Search()
        {
            DB db = new DB();
            ClickerDataGrid.Rows.Clear();

            string searchString = "select * from clicker " +
                "inner join raysoyuz " +
                "on clicker.idRaysouyz = raysoyuz.id " +
                "inner join region " +
                "on raysoyuz.idRegion = region.id " +
                $"where concat (clicker.name, surname, patronymic, raysoyuz.name, region.name) like '%" + SearchTextBox.Text + "%'";
            
            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(searchString, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    ClickerDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadInfoClicker();
        }

        private void DeleteClickerButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from clicker where id = {ClickerDataGrid[0, ClickerDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            MySqlCommand command2 = new MySqlCommand($"delete from raysoyuz where id = {ClickerDataGrid[5, ClickerDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            MySqlCommand command3 = new MySqlCommand($"delete from region where id = {ClickerDataGrid[7, ClickerDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                command3.ExecuteNonQuery();
                MessageBox.Show("Заготовщик удален");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoClicker();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DB db = new DB();
                ClickerDataGrid.Rows.Clear();

                string query = "select * from clicker " +
                    "inner join raysoyuz " +
                    "on clicker.idRaysouyz = raysoyuz.id " +
                    "inner join region " +
                    "on raysoyuz.idRegion = region.id " +
                    "order by clicker.name asc";

                db.openConnection();
                using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
                {
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    List<string[]> dataDB = new List<string[]>();
                    while (reader.Read())
                    {
                        dataDB.Add(new string[reader.FieldCount]);

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                        }
                    }
                    reader.Close();
                    foreach (string[] s in dataDB)
                        ClickerDataGrid.Rows.Add(s);
                }
                db.closeConnection();
            }
            else
                loadInfoClicker();
        }

        private void ClickerForm_Load(object sender, EventArgs e)
        {
            loadInfoClicker();
        }

        private void ClickerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchClickerButton_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
