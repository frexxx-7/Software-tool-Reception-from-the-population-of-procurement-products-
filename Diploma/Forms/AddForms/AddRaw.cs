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
    public partial class AddRaw : Form
    {
        string idRaw = null;
        string idTypeOfRaw = null;
        public AddRaw(string idRaw, string idTypeOfRaw)
        {
            InitializeComponent();

            if (idRaw != null && idTypeOfRaw!=null)
            {
                this.idRaw = idRaw;
                this.idTypeOfRaw = idTypeOfRaw;
                AddButton.Text = "Сохранить";
                label1.Text = "Изменить сырье";
            }
        }
        private void searchDelivery()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM raw WHERE id = '{idRaw}'";
            string queryInfo2 = $"SELECT * FROM typeofraw WHERE id = '{idTypeOfRaw}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());
            MySqlCommand mySqlCommand2 = new MySqlCommand(queryInfo2, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader[1].ToString();
                UnitTextBox.Text = reader[2].ToString();
                PriceTextBox.Text = reader[3].ToString();
                QuantityTextBox.Text = reader[4].ToString();
                DiscountTextBox.Text = reader[5].ToString();
            }
            reader.Close();

            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                for (int i = 0; i < TypeComboBox.Items.Count; i++)
                {
                    if (reader2["id"].ToString() != "")
                    {
                        if (Convert.ToInt32((TypeComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader2["id"]))
                        {
                            TypeComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader2.Close();

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idRaw == null)
            {
                DB db = new DB();

                //MySqlCommand command1 = new MySqlCommand($"INSERT into typeofraw (name) values(@name)", db.getConnection());
                //MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id FROM typeofraw WHERE (id = LAST_INSERT_ID())", db.getConnection());
                //command1.Parameters.AddWithValue("@name", NameTypeRawTextBox.Text);
                db.openConnection();

                /*try
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
                    idTypeOfRaw = reader[0].ToString();
                }
                reader.Close();

                db.closeConnection();*/

                MySqlCommand command = new MySqlCommand($"INSERT into raw (name, unit, price, quantity, discount, idTypeOfRaw) values(@name, @unit, @price, @quantity, @discount, @idTypeOfRaw)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@unit", UnitTextBox.Text);
                command.Parameters.AddWithValue("@price", double.Parse(PriceTextBox.Text));
                command.Parameters.AddWithValue("@quantity", double.Parse(QuantityTextBox.Text));
                command.Parameters.AddWithValue("@discount", double.Parse(DiscountTextBox.Text));
                command.Parameters.AddWithValue("@idTypeOfRaw", (TypeComboBox.SelectedItem as ComboboxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сырье добавлено");
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

                /*MySqlCommand command1 = new MySqlCommand($"update typeofraw set name = @name where id={idTypeOfRaw}", db.getConnection());
                command1.Parameters.AddWithValue("@name", NameTypeRawTextBox.Text);
                db.openConnection();

                try
                {
                    command1.ExecuteNonQuery();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();*/

                MySqlCommand command = new MySqlCommand($"update raw set name=@name, unit=@unit, price=@price, quantity=@quantity, discount=@discount, idTypeOfRaw=@idTypeOfRaw where id={idRaw}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@unit", UnitTextBox.Text);
                command.Parameters.AddWithValue("@price", double.Parse(PriceTextBox.Text));
                command.Parameters.AddWithValue("@quantity", double.Parse(QuantityTextBox.Text));
                command.Parameters.AddWithValue("@discount", double.Parse(DiscountTextBox.Text));
                command.Parameters.AddWithValue("@idTypeOfRaw", (TypeComboBox.SelectedItem as ComboboxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сырье изменено");
                    this.Close();

                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }

        private void AddRaw_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfoTypeCbb = $"SELECT id, name FROM typeofraw";

            MySqlCommand mySqlCommandTypeCbb = new MySqlCommand(queryInfoTypeCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerTypeCbb = mySqlCommandTypeCbb.ExecuteReader();
            while (readerTypeCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerTypeCbb[1]} ";
                item.Value = readerTypeCbb[0];
                TypeComboBox.Items.Add(item);
            }
            readerTypeCbb.Close();

            db.closeConnection();
            searchDelivery();
        }
    }
}
