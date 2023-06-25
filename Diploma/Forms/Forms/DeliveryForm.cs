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
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void DeliveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddDelivery(DeliveryDataGrid[0, DeliveryDataGrid.SelectedCells[0].RowIndex].Value.ToString(), DeliveryDataGrid[6, DeliveryDataGrid.SelectedCells[0].RowIndex].Value.ToString()).Show();
        }
        private void loadInfoDelivery()
        {
            DB db = new DB();
            DeliveryDataGrid.Rows.Clear();

            string query = $"select delivery.*, locality.name, regions.name as regionsName, areas.name as areasName from delivery " +
                $"inner join locality " +
                $"on delivery.idLocality = locality.id " +
                $"inner join areas on locality.area=areas.id " +
                $"inner join regions on locality.region = regions.id ";

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
                    DeliveryDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }
        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            loadInfoDelivery();
        }

        private void AddDeliveryButton_Click(object sender, EventArgs e)
        {
            new AddDelivery(null, null).Show();
        }

        private void Search()
        {
            DB db = new DB();
            DeliveryDataGrid.Rows.Clear();

            string searchString = $"select delivery.*, locality.name, regions.name as regionsName, areas.name as areasName from delivery " +
                $"inner join locality " +
                $"on delivery.idLocality = locality.id " +
                $"inner join areas on locality.id=areas.id " +
                $"inner join regions on locality.id = regions.id "+
                $"where  concat (delivery.name, surname, patronymic, phone, numberPassport, locality.name, regions.name, areas.name) like '%" + SearchTextBox.Text + "%'";
            
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
                    DeliveryDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadInfoDelivery();
        }

        private void DeleteDeliveryButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from delivery where id = {DeliveryDataGrid[0, DeliveryDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            MySqlCommand command2 = new MySqlCommand($"delete from locality where id = {DeliveryDataGrid[6, DeliveryDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
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
                MessageBox.Show("Сдатчик удален");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoDelivery();
        }

        private void SearchDeliveryButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DB db = new DB();
                DeliveryDataGrid.Rows.Clear();

                string query = "select * from delivery " +
                    $"inner join locality " +
                    $"on delivery.idLocality = locality.id " +
                    "order by delivery.surname asc";

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
                        DeliveryDataGrid.Rows.Add(s);
                }
                db.closeConnection();
            }
            else
                loadInfoDelivery();
        }
    }
}
