using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Diploma.DataBase;
using Diploma.Forms.AddForms;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;

namespace Diploma.Forms.Forms
{
    public partial class ReportForm : Form
    {
        private int activeRow = 1;
        private int maxRow = 10;
        private int[] selectProducts;

        private string raysouyuzName;
        private string regionName;

        private string localityName;
        private string region;
        private string area;

        private double sumMassN;
        private double sumMassDis;
        private double sumCleanMass;
        private double sumGeneral;
        private double sumGeneralN;

        private string idAcceptancereceipt;

        public ReportForm()
        {
            InitializeComponent();
            selectProducts = new int[maxRow];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO acceptancereceipt (idDelivery, idClicker) VALUES (@idDelivery, @idClicker)", db.getConnection());
            MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id FROM acceptancereceipt WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command.Parameters.Add("@idDelivery", MySqlDbType.Int32).Value = (DeliveryComboBox.SelectedItem as ComboboxItem).Value;
            command.Parameters.Add("@idClicker", MySqlDbType.Int32).Value = (ClickerComboBox.SelectedItem as ComboboxItem).Value;

            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            MySqlDataReader reader1 = commandGetLastID.ExecuteReader();
            while (reader1.Read())
            {
                idAcceptancereceipt = reader1[0].ToString();
            }
            reader1.Close();
            db.closeConnection();

            string query = "Insert into rawinacceptancereceipt (idRaw, idAcceptancereceipt) values ";
            for (int i = 0; i < ReportDataGrid.RowCount - 1; i++)
            {
                query += $"({ReportDataGrid.Rows[i].Cells[11].Value}, {idAcceptancereceipt}), ";
            }
            query = query.Remove(query.Length - 2);
            MySqlCommand command2 = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            try
            {
                command2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            db.closeConnection();

            loadInfoClicker((int)(ClickerComboBox.SelectedItem as ComboboxItem).Value);
            loadIngoDelivery((int)(DeliveryComboBox.SelectedItem as ComboboxItem).Value);
            // Открываем исходный документ Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document sourceDoc = wordApp.Documents.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Шаблон.docx"));


            // Копируем содержимое документа в буфер обмена
            sourceDoc.Content.Copy();

            // Создаем новый документ Word и вставляем скопированный текст
            Document targetDoc = wordApp.Documents.Add();
            targetDoc.Content.Paste();

            // Получаем коллекцию закладок в новом документе
            Bookmark bookmark = targetDoc.Bookmarks["КодСдатчика"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{(DeliveryComboBox.SelectedItem as ComboboxItem).Value}";
                
            }
            // Получаем коллекцию закладок в новом документе
            bookmark = targetDoc.Bookmarks["КодПолучателя"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{(ClickerComboBox.SelectedItem as ComboboxItem).Value}";
            }

            bookmark = targetDoc.Bookmarks["НаименованиеОрганизации"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{raysouyuzName}";
            }
            bookmark = targetDoc.Bookmarks["АдресЗаготовитель"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{regionName}";
            }
            bookmark = targetDoc.Bookmarks["ФамилияИИнициалы"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{(ClickerComboBox.SelectedItem as ComboboxItem).Text}";
            }
            bookmark = targetDoc.Bookmarks["АдресСдатчик"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{localityName + " " + region + " " + area}";
            }
            bookmark = targetDoc.Bookmarks["День"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{DateTime.Now.ToString("dd")}";
            }
            bookmark = targetDoc.Bookmarks["Месяц"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{DateTime.Now.ToString("MMMM")}";
            }
            bookmark = targetDoc.Bookmarks["Год"];

            // Если закладка существует
            if (bookmark != null)
            {
                // Получаем объект диапазона, связанный с закладкой
                Range range = bookmark.Range;

                // Добавляем текст в диапазон
                range.Text = $"{DateTime.Now.ToString("yyyy")}";
            }
            // Закрываем исходный документ Word
            sourceDoc.Close();

            // Открываем диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Документ Word (*.docx)|*.docx";
            saveFileDialog1.Title = "Сохранить скопированный документ в";
            saveFileDialog1.ShowDialog();

            // Сохраняем новый документ Word в выбранный пользователем путь
            string targetPath = saveFileDialog1.FileName;
            if (targetPath != "")
            {
                Microsoft.Office.Interop.Word.Table table = targetDoc.Tables[4];
                Microsoft.Office.Interop.Word.Row row = null;
                targetDoc.SaveAs2(targetPath);
                for (int i = 0; i < ReportDataGrid.RowCount; i++)
                {
                    for (int j = 0; j < ReportDataGrid.ColumnCount-1; j++)
                    {
                        if (ReportDataGrid.Rows[i].Cells[j].Value!=null)
                        {
                            table.Cell(4 + i, j+1).Range.Text = ReportDataGrid.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                }
                table.Cell(table.Rows.Count, 3).Range.Text = sumMassN.ToString();
                table.Cell(table.Rows.Count, 5).Range.Text = sumMassDis.ToString();
                table.Cell(table.Rows.Count, 6).Range.Text = sumCleanMass.ToString();
                table.Cell(table.Rows.Count, 8).Range.Text = sumGeneral.ToString();
                table.Cell(table.Rows.Count, 11).Range.Text = sumGeneralN.ToString();
            }

            // Закрываем все документы и приложение Word
            targetDoc.Close();
            wordApp.Quit();

            // Создаем объект приложения Word
            Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            // Открываем документ
            Document wordDocument = wordApplication.Documents.Open(targetPath);
            // Запускаем приложение Word
            wordApplication.Visible = true;
        }

            //Занесение данных из БД в ComboBox
        private void ReportForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfoClickerCbb = $"SELECT id, name, surname, patronymic FROM clicker";
            string queryInfoDeliveryCbb = $"SELECT id, name, surname, patronymic FROM delivery";
            string queryInfoRawCbb = $"SELECT id, name FROM raw";

            MySqlCommand mySqlCommandClickerCbb = new MySqlCommand(queryInfoClickerCbb, db.getConnection());
            MySqlCommand mySqlCommandDeliveryCbb = new MySqlCommand(queryInfoDeliveryCbb, db.getConnection());
            MySqlCommand mySqlCommandRawCbb = new MySqlCommand(queryInfoRawCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerClickerCbb = mySqlCommandClickerCbb.ExecuteReader();
            while (readerClickerCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerClickerCbb[1]} {readerClickerCbb[3]} {readerClickerCbb[2]}";
                item.Value = readerClickerCbb[0];
                ClickerComboBox.Items.Add(item);
            }
            readerClickerCbb.Close();


            MySqlDataReader readerDeliveryCbb = mySqlCommandDeliveryCbb.ExecuteReader();
            while (readerDeliveryCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerDeliveryCbb[1]} {readerDeliveryCbb[3]} {readerDeliveryCbb[2]}";
                item.Value = readerDeliveryCbb[0];
                DeliveryComboBox.Items.Add(item);
            }
            readerDeliveryCbb.Close();


            MySqlDataReader readerRawCbb = mySqlCommandRawCbb.ExecuteReader();
            while (readerRawCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $" {readerRawCbb[1]}";
                item.Value = readerRawCbb[0];
                RawComboBox.Items.Add(item);
            }
            readerRawCbb.Close();

            db.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectProducts[activeRow - 1] = (int)(RawComboBox.SelectedItem as ComboboxItem).Value;
            activeRow++;
            showProducts();
        }
        private void loadInfoClicker(int idClicker)//Загрузка информации о заготовщиках
        {
            DB db = new DB();
            string query = $"select clicker.*, raysoyuz.name as raysoyuzName, region.name as regionName from clicker " +
                $"INNER join raysoyuz on clicker.idRaysouyz = raysoyuz.id " +
                $"INNER JOIN region on raysoyuz.idRegion = region.id " +
                $"where clicker.id = {idClicker}";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    raysouyuzName = reader["raysoyuzName"].ToString();
                    regionName = reader["regionName"].ToString();
                }
                reader.Close();
            }
            db.closeConnection();
        }
        private void loadIngoDelivery(int idDelivery)//Загрузка информации о сдатчиках
        {
            DB db = new DB();
            string query = $"select delivery.*, locality.name as localityName, locality.region, locality.area from delivery " +
                $"inner join locality on delivery.idLocality = locality.id " +
                $"where delivery.id = {idDelivery}";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    localityName = reader["localityName"].ToString();
                    region = reader["region"].ToString();
                    area = reader["area"].ToString();
                }
                reader.Close();
            }
            db.closeConnection();
        }
        private void showProducts()//Загрузка информации о продуктах в datagridview
        {
            ReportDataGrid.Rows.Clear();
            for (int i = 0; i < maxRow; i++)
            {
                DB db = new DB();
                string query = $"select raw.*, typeofraw.name as nameTypeOf from raw " +
                    $"inner join typeofraw on raw.idTypeOfRaw = typeofraw.id " +
                    $"where raw.id={selectProducts[i]}";

                db.openConnection();
                using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
                {
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    List<string[]> dataDB = new List<string[]>();
                    while (reader.Read())
                    {
                        dataDB.Add(new string[12]);
                        dataDB[dataDB.Count - 1][0] = reader["name"].ToString();
                        dataDB[dataDB.Count - 1][1] = reader["nameTypeOf"].ToString();
                        dataDB[dataDB.Count - 1][3] = reader["discount"].ToString();
                        dataDB[dataDB.Count - 1][6] = reader["price"].ToString();
                        dataDB[dataDB.Count - 1][11] = reader["id"].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in dataDB)
                        ReportDataGrid.Rows.Add(s);
                }
                db.closeConnection();
            }
        }
        private void calculateVoid()//Рассчет значении в datagridview
        {
            for (int i = 0; i < ReportDataGrid.RowCount; i++)
            {
                if (ReportDataGrid.Rows[i].Cells[2].Value!=null)
                {
                    double mass = double.Parse(ReportDataGrid.Rows[i].Cells[2].Value.ToString());
                    sumMassN += mass;
                    double discount = double.Parse(ReportDataGrid.Rows[i].Cells[3].Value.ToString());
                    double discountMass = ((mass / 100) * discount);
                    sumMassDis+= discountMass;
                    double purestMass = mass - discountMass;
                    sumCleanMass+= purestMass;
                    ReportDataGrid.Rows[i].Cells[4].Value = discountMass;
                    ReportDataGrid.Rows[i].Cells[5].Value = purestMass;
                    ReportDataGrid.Rows[i].Cells[7].Value = purestMass * double.Parse(ReportDataGrid.Rows[i].Cells[6].Value.ToString());
                    sumGeneral += purestMass * double.Parse(ReportDataGrid.Rows[i].Cells[6].Value.ToString());
                    ReportDataGrid.Rows[i].Cells[7].Value = purestMass * double.Parse(ReportDataGrid.Rows[i].Cells[6].Value.ToString());
                    if (ReportDataGrid.Rows[i].Cells[9].Value == null)
                        ReportDataGrid.Rows[i].Cells[9].Value = 0;
                    ReportDataGrid.Rows[i].Cells[10].Value = Convert.ToDouble(ReportDataGrid.Rows[i].Cells[7].Value) + Convert.ToDouble(ReportDataGrid.Rows[i].Cells[9].Value);
                    sumGeneralN += Convert.ToDouble(ReportDataGrid.Rows[i].Cells[7].Value) + Convert.ToDouble(ReportDataGrid.Rows[i].Cells[9].Value);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)//Изменение состояния кнопки 
        {
            CalculateButton.Visible = false;

            if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                CalculateButton.Visible = true;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            calculateVoid();
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
