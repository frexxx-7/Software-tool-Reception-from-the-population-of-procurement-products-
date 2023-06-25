namespace Diploma.Forms.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ClickerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeliveryComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.RawComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumRub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllSumVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приемная квитанция";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(939, 551);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вывод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 441);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ClickerComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DeliveryComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1043, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сдатчик и Заготовитель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заготовитель:";
            // 
            // ClickerComboBox
            // 
            this.ClickerComboBox.FormattingEnabled = true;
            this.ClickerComboBox.Location = new System.Drawing.Point(133, 57);
            this.ClickerComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClickerComboBox.Name = "ClickerComboBox";
            this.ClickerComboBox.Size = new System.Drawing.Size(207, 24);
            this.ClickerComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сдатчик:";
            // 
            // DeliveryComboBox
            // 
            this.DeliveryComboBox.FormattingEnabled = true;
            this.DeliveryComboBox.Location = new System.Drawing.Point(83, 11);
            this.DeliveryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveryComboBox.Name = "DeliveryComboBox";
            this.DeliveryComboBox.Size = new System.Drawing.Size(207, 24);
            this.DeliveryComboBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.RawComboBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ReportDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1043, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RawComboBox
            // 
            this.RawComboBox.FormattingEnabled = true;
            this.RawComboBox.Location = new System.Drawing.Point(85, 25);
            this.RawComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RawComboBox.Name = "RawComboBox";
            this.RawComboBox.Size = new System.Drawing.Size(207, 24);
            this.RawComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сырье:";
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct,
            this.Units,
            this.Mass,
            this.DiscountPercent,
            this.DiscountMass,
            this.NetWeight,
            this.PurchasePrice,
            this.SumRub,
            this.VATRate,
            this.SumVAT,
            this.AllSumVAT,
            this.IDRow});
            this.ReportDataGrid.Location = new System.Drawing.Point(8, 75);
            this.ReportDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.RowHeadersWidth = 51;
            this.ReportDataGrid.RowTemplate.Height = 24;
            this.ReportDataGrid.Size = new System.Drawing.Size(1031, 318);
            this.ReportDataGrid.TabIndex = 0;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Наименование продукции сырья, сорт, качество, размер (по стандарту)";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Width = 125;
            // 
            // Units
            // 
            this.Units.HeaderText = "Един. измерения";
            this.Units.MinimumWidth = 6;
            this.Units.Name = "Units";
            this.Units.Width = 125;
            // 
            // Mass
            // 
            this.Mass.HeaderText = "Масса нетто/ количество сданной продукции";
            this.Mass.MinimumWidth = 6;
            this.Mass.Name = "Mass";
            this.Mass.Width = 125;
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.HeaderText = "Скидка на отходы %";
            this.DiscountPercent.MinimumWidth = 6;
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.Width = 125;
            // 
            // DiscountMass
            // 
            this.DiscountMass.HeaderText = "Скидка на отходы масса кг";
            this.DiscountMass.MinimumWidth = 6;
            this.DiscountMass.Name = "DiscountMass";
            this.DiscountMass.Width = 125;
            // 
            // NetWeight
            // 
            this.NetWeight.HeaderText = "Чистая масса нетто/ (количе-ство) принятая (-ое) к оплате";
            this.NetWeight.MinimumWidth = 6;
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.Width = 125;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Закупочная цена, руб. коп.";
            this.PurchasePrice.MinimumWidth = 6;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Width = 125;
            // 
            // SumRub
            // 
            this.SumRub.HeaderText = "Сумма, руб. коп.";
            this.SumRub.MinimumWidth = 6;
            this.SumRub.Name = "SumRub";
            this.SumRub.Width = 125;
            // 
            // VATRate
            // 
            this.VATRate.HeaderText = "Ставка НДС %";
            this.VATRate.MinimumWidth = 6;
            this.VATRate.Name = "VATRate";
            this.VATRate.Width = 125;
            // 
            // SumVAT
            // 
            this.SumVAT.HeaderText = "Сумма НДС, руб. коп.";
            this.SumVAT.MinimumWidth = 6;
            this.SumVAT.Name = "SumVAT";
            this.SumVAT.Width = 125;
            // 
            // AllSumVAT
            // 
            this.AllSumVAT.HeaderText = "Всего сумма с НДС, руб. коп.";
            this.AllSumVAT.MinimumWidth = 6;
            this.AllSumVAT.Name = "AllSumVAT";
            this.AllSumVAT.Width = 125;
            // 
            // IDRow
            // 
            this.IDRow.HeaderText = "Код продукта";
            this.IDRow.MinimumWidth = 6;
            this.IDRow.Name = "IDRow";
            this.IDRow.Visible = false;
            this.IDRow.Width = 125;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(16, 551);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(125, 42);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Visible = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 606);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClickerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DeliveryComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox RawComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumRub;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllSumVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRow;
    }
}