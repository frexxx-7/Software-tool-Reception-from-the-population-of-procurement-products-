using Diploma.DataBase;
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
    public partial class AddClicker : Form
    {
        string idClicker = null;
        string idRaysoyuz = null;
        string idRegion = null;
        public AddClicker(string idClicker, string idRaysoyuz, string idRegion)
        {
            InitializeComponent();

            if (idClicker != null && idRaysoyuz!=null && idRegion != null)
            {
                this.idClicker = idClicker;
                this.idRaysoyuz = idRaysoyuz;
                this.idRegion = idRegion;
                searchDelivery();
                AddButton.Text = "Сохранить";
                label1.Text = "Изменить заготовщика";
            }
        }
        private void searchDelivery()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM clicker WHERE id = '{idClicker}'";
            string queryInfo2 = $"SELECT * FROM raysoyuz WHERE id = '{idRaysoyuz}'";
            string queryInfo3 = $"SELECT * FROM region WHERE id = '{idRegion}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());
            MySqlCommand mySqlCommand2 = new MySqlCommand(queryInfo2, db.getConnection());
            MySqlCommand mySqlCommand3 = new MySqlCommand(queryInfo3, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader[1].ToString();
                SurnameTextBox.Text = reader[2].ToString();
                PatronymicTextBox.Text = reader[3].ToString();
            }
            reader.Close();

            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                NameRaysoyuzTextBox.Text = reader2[1].ToString();
            }
            reader2.Close();

            MySqlDataReader reader3 = mySqlCommand3.ExecuteReader();
            while (reader3.Read())
            {
                NameRegionTextBox.Text = reader3[1].ToString();
            }
            reader3.Close();

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idClicker == null)
            {
                string idRegion = "";
                string idRaysoyuz = "";
                DB db = new DB();

                MySqlCommand command1 = new MySqlCommand($"INSERT into region (name) values(@name)", db.getConnection());
                MySqlCommand commandGetLastID1 = new MySqlCommand($"SELECT id FROM region WHERE (id = LAST_INSERT_ID())", db.getConnection());
                command1.Parameters.AddWithValue("@name", NameRegionTextBox.Text);
                db.openConnection();

                try
                {
                    command1.ExecuteNonQuery();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySqlDataReader reader1 = commandGetLastID1.ExecuteReader();
                while (reader1.Read())
                {
                    idRegion = reader1[0].ToString();
                }
                reader1.Close();

                db.closeConnection();

                MySqlCommand command2 = new MySqlCommand($"INSERT into raysoyuz (name, idRegion) values(@name, @idRegion)", db.getConnection());
                MySqlCommand commandGetLastID2 = new MySqlCommand($"SELECT id FROM raysoyuz WHERE (id = LAST_INSERT_ID())", db.getConnection());
                command2.Parameters.AddWithValue("@name", NameRaysoyuzTextBox.Text);
                command2.Parameters.AddWithValue("@idRegion", idRegion);
                db.openConnection();

                try
                {
                    command2.ExecuteNonQuery();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySqlDataReader reader2 = commandGetLastID2.ExecuteReader();
                while (reader2.Read())
                {
                    idRaysoyuz = reader2[0].ToString();
                }
                reader2.Close();


                MySqlCommand command = new MySqlCommand($"INSERT into clicker (name, surname, patronymic, idRaysouyz) values(@name, @surname, @patronymic, @idRaysouyz)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@idRaysouyz", idRaysoyuz);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Заготовщик добавлен");
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

                MySqlCommand command1 = new MySqlCommand($"update region set name = @name where id={idRegion}", db.getConnection());
                command1.Parameters.AddWithValue("@name", NameRegionTextBox.Text);
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

                MySqlCommand command2 = new MySqlCommand($"update raysoyuz set name = @name where id={idRaysoyuz}", db.getConnection());
                command2.Parameters.AddWithValue("@name", NameRaysoyuzTextBox.Text);
                db.openConnection();

                try
                {
                    command2.ExecuteNonQuery();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();

                MySqlCommand command = new MySqlCommand($"update clicker set name=@name, surname=@surname, patronymic=@patronymic, idRaysouyz=@idRaysouyz where id={idClicker}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@idRaysouyz", idRaysoyuz);

                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Заготовщик изменен");
                    this.Close();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }
    }
}
