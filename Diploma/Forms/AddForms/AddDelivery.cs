using Diploma.DataBase;
using Diploma.Forms.Forms;
using MySql.Data.MySqlClient;
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

namespace Diploma.Forms.AddForms
{
    public partial class AddDelivery : Form
    {
        string idDelivery = null;
        string idLocality = null;
        public AddDelivery(string idDelivery, string idLocality)
        {
            InitializeComponent();

            if (idDelivery != null && idLocality!=null)
            {
                this.idDelivery = idDelivery;
                this.idLocality = idLocality;
                AddButton.Text = "Сохранить";
                label1.Text = "Изменить сдатчика";
            }
        }
        private void searchDelivery()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM delivery WHERE id = '{idDelivery}'";
            string queryInfo2 = $"SELECT locality.id, locality.name, areas.id as areasId, areas.name as areasName, regions.id as regionsId, regions.name as regionsName  FROM locality " +
                $"inner join areas on locality.area=areas.id " +
                $"inner join regions on locality.region = regions.id " +
                $"WHERE locality.id = {idLocality}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());
            MySqlCommand mySqlCommand2 = new MySqlCommand(queryInfo2, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader[1].ToString();
                SurnameTextBox.Text = reader[2].ToString();
                PatronymicTextBox.Text = reader[3].ToString();
                NumberProneTextBox.Text = reader[4].ToString();
                NumberPassport.Text = reader[5].ToString();
            }
            reader.Close();

            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                for (int i = 0; i < AreaComboBox.Items.Count; i++)
                {
                    if (reader2["areasId"].ToString() != "")
                    {
                        if (Convert.ToInt32((AreaComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader2["areasId"]))
                        {
                            AreaComboBox.SelectedIndex = i;
                        }
                    }
                }
                for (int i = 0; i < RegionComboBox.Items.Count; i++)
                {
                    if (reader2["regionsId"].ToString() != "")
                    {
                        if (Convert.ToInt32((RegionComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader2["regionsId"]))
                        {
                            RegionComboBox.SelectedIndex = i;
                        }
                    }
                }
                LocalityTextBox.Text = reader2["name"].ToString();
            }
            reader2.Close();

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idDelivery == null)
            {
                string idLocality = "";
                DB db = new DB();

                MySqlCommand command1 = new MySqlCommand($"INSERT into locality (name, region, area) values(@name, @region, @area)", db.getConnection());
                MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id FROM locality WHERE (id = LAST_INSERT_ID())", db.getConnection());
                command1.Parameters.AddWithValue("@name", LocalityTextBox.Text);
                command1.Parameters.AddWithValue("@region", (RegionComboBox.SelectedItem as ComboboxItem).Value);
                command1.Parameters.AddWithValue("@area", (AreaComboBox.SelectedItem as ComboboxItem).Value);
                db.openConnection();

                try
                {
                    command1.ExecuteNonQuery();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySqlDataReader reader = commandGetLastID.ExecuteReader();
                while (reader.Read())
                {
                    idLocality = reader[0].ToString();
                }
                reader.Close();

                db.closeConnection();

                MySqlCommand command = new MySqlCommand($"INSERT into delivery (name, surname, patronymic, phone, numberPassport, idLocality) values(@name, @surname, @patronymic, @phone, @numberPassport, @idLocality)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@phone", NumberProneTextBox.Text);
                command.Parameters.AddWithValue("@numberPassport", NumberPassport.Text);
                command.Parameters.AddWithValue("@idLocality", idLocality);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сдатчик добавлен");
                    this.Close();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
            else
            {
                DB db = new DB();

                MySqlCommand command1 = new MySqlCommand($"update locality set name = @name, region=@region, area=@area where id={idLocality}", db.getConnection());
                command1.Parameters.AddWithValue("@name", LocalityTextBox.Text);
                command1.Parameters.AddWithValue("@region", (RegionComboBox.SelectedItem as ComboboxItem).Value);
                command1.Parameters.AddWithValue("@area", (AreaComboBox.SelectedItem as ComboboxItem).Value);
                db.openConnection();

                try
                {
                    command1.ExecuteNonQuery();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();

                MySqlCommand command = new MySqlCommand($"update delivery set name=@name, surname=@surname, patronymic=@patronymic, phone=@phone, numberPassport=@numberPassport where id={idDelivery}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@phone", NumberProneTextBox.Text);
                command.Parameters.AddWithValue("@numberPassport", NumberPassport.Text);
                command.Parameters.AddWithValue("@idLocality", idLocality);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сдатчик изменен");
                    this.Close();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }

        private void AddDelivery_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM areas";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {reader["name"]}";
                item.Value = reader["id"];
                AreaComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();

            string query = $"SELECT * FROM regions";
            MySqlCommand mySqlCommand2 = new MySqlCommand(query, db.getConnection());

            db.openConnection();

            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {reader2["name"]}";
                item.Value = reader2["id"];
                RegionComboBox.Items.Add(item);
            }
            reader2.Close();

            db.closeConnection();
            if (idDelivery != null && idLocality != null)
            {
                searchDelivery();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
