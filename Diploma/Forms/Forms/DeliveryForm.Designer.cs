namespace Diploma.Forms
{
    partial class DeliveryForm
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
            this.DeliveryDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDeliveryButton = new System.Windows.Forms.Button();
            this.ChangeDeliveryButton = new System.Windows.Forms.Button();
            this.DeleteDeliveryButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchDeliveryButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryDataGrid
            // 
            this.DeliveryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.patronymic,
            this.phone,
            this.numberPassport,
            this.idLocality,
            this.nameLocality,
            this.region,
            this.area});
            this.DeliveryDataGrid.Location = new System.Drawing.Point(12, 87);
            this.DeliveryDataGrid.Name = "DeliveryDataGrid";
            this.DeliveryDataGrid.ReadOnly = true;
            this.DeliveryDataGrid.RowHeadersWidth = 51;
            this.DeliveryDataGrid.RowTemplate.Height = 24;
            this.DeliveryDataGrid.Size = new System.Drawing.Size(960, 406);
            this.DeliveryDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сдатчики";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(978, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 410);
            this.panel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(21, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Фамилия по возрастанию";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фильтрация";
            // 
            // AddDeliveryButton
            // 
            this.AddDeliveryButton.Location = new System.Drawing.Point(12, 535);
            this.AddDeliveryButton.Name = "AddDeliveryButton";
            this.AddDeliveryButton.Size = new System.Drawing.Size(129, 48);
            this.AddDeliveryButton.TabIndex = 4;
            this.AddDeliveryButton.Text = "Добавить";
            this.AddDeliveryButton.UseVisualStyleBackColor = true;
            this.AddDeliveryButton.Click += new System.EventHandler(this.AddDeliveryButton_Click);
            // 
            // ChangeDeliveryButton
            // 
            this.ChangeDeliveryButton.Location = new System.Drawing.Point(192, 535);
            this.ChangeDeliveryButton.Name = "ChangeDeliveryButton";
            this.ChangeDeliveryButton.Size = new System.Drawing.Size(129, 48);
            this.ChangeDeliveryButton.TabIndex = 5;
            this.ChangeDeliveryButton.Text = "Изменить";
            this.ChangeDeliveryButton.UseVisualStyleBackColor = true;
            this.ChangeDeliveryButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteDeliveryButton
            // 
            this.DeleteDeliveryButton.Location = new System.Drawing.Point(389, 535);
            this.DeleteDeliveryButton.Name = "DeleteDeliveryButton";
            this.DeleteDeliveryButton.Size = new System.Drawing.Size(129, 48);
            this.DeleteDeliveryButton.TabIndex = 6;
            this.DeleteDeliveryButton.Text = "Удалить";
            this.DeleteDeliveryButton.UseVisualStyleBackColor = true;
            this.DeleteDeliveryButton.Click += new System.EventHandler(this.DeleteDeliveryButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(665, 548);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(352, 22);
            this.SearchTextBox.TabIndex = 7;
            // 
            // SearchDeliveryButton
            // 
            this.SearchDeliveryButton.Location = new System.Drawing.Point(1072, 535);
            this.SearchDeliveryButton.Name = "SearchDeliveryButton";
            this.SearchDeliveryButton.Size = new System.Drawing.Size(129, 48);
            this.SearchDeliveryButton.TabIndex = 8;
            this.SearchDeliveryButton.Text = "Поиск";
            this.SearchDeliveryButton.UseVisualStyleBackColor = true;
            this.SearchDeliveryButton.Click += new System.EventHandler(this.SearchDeliveryButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1097, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Код сдатчика";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 125;
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.MinimumWidth = 6;
            this.patronymic.Name = "patronymic";
            this.patronymic.ReadOnly = true;
            this.patronymic.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // numberPassport
            // 
            this.numberPassport.HeaderText = "Номер паспорта";
            this.numberPassport.MinimumWidth = 6;
            this.numberPassport.Name = "numberPassport";
            this.numberPassport.ReadOnly = true;
            this.numberPassport.Width = 125;
            // 
            // idLocality
            // 
            this.idLocality.HeaderText = "Код населенного пункта";
            this.idLocality.MinimumWidth = 6;
            this.idLocality.Name = "idLocality";
            this.idLocality.ReadOnly = true;
            this.idLocality.Visible = false;
            this.idLocality.Width = 125;
            // 
            // nameLocality
            // 
            this.nameLocality.HeaderText = "Населенный пункт";
            this.nameLocality.MinimumWidth = 6;
            this.nameLocality.Name = "nameLocality";
            this.nameLocality.ReadOnly = true;
            this.nameLocality.Width = 125;
            // 
            // region
            // 
            this.region.HeaderText = "Район";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Width = 125;
            // 
            // area
            // 
            this.area.HeaderText = "Область";
            this.area.MinimumWidth = 6;
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Width = 125;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchDeliveryButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteDeliveryButton);
            this.Controls.Add(this.ChangeDeliveryButton);
            this.Controls.Add(this.AddDeliveryButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliveryDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сдатчик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeliveryForm_FormClosed);
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveryDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddDeliveryButton;
        private System.Windows.Forms.Button ChangeDeliveryButton;
        private System.Windows.Forms.Button DeleteDeliveryButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchDeliveryButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}