namespace Diploma.Forms
{
    partial class RawForm
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
            this.RawDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddRawButton = new System.Windows.Forms.Button();
            this.ChangeRawButton = new System.Windows.Forms.Button();
            this.DeleteRawButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchRawButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeOfRaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeRaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RawDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawDataGrid
            // 
            this.RawDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RawDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Unit,
            this.price,
            this.quantity,
            this.discount,
            this.idTypeOfRaw,
            this.idTypeRaw,
            this.typeName});
            this.RawDataGrid.Location = new System.Drawing.Point(12, 87);
            this.RawDataGrid.Name = "RawDataGrid";
            this.RawDataGrid.ReadOnly = true;
            this.RawDataGrid.RowHeadersWidth = 51;
            this.RawDataGrid.RowTemplate.Height = 24;
            this.RawDataGrid.Size = new System.Drawing.Size(960, 406);
            this.RawDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сырье";
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
            this.checkBox1.Size = new System.Drawing.Size(204, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Название по возрастанию";
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
            // AddRawButton
            // 
            this.AddRawButton.Location = new System.Drawing.Point(12, 535);
            this.AddRawButton.Name = "AddRawButton";
            this.AddRawButton.Size = new System.Drawing.Size(129, 48);
            this.AddRawButton.TabIndex = 4;
            this.AddRawButton.Text = "Добавить";
            this.AddRawButton.UseVisualStyleBackColor = true;
            this.AddRawButton.Click += new System.EventHandler(this.AddRawButton_Click);
            // 
            // ChangeRawButton
            // 
            this.ChangeRawButton.Location = new System.Drawing.Point(192, 535);
            this.ChangeRawButton.Name = "ChangeRawButton";
            this.ChangeRawButton.Size = new System.Drawing.Size(129, 48);
            this.ChangeRawButton.TabIndex = 5;
            this.ChangeRawButton.Text = "Изменить";
            this.ChangeRawButton.UseVisualStyleBackColor = true;
            this.ChangeRawButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteRawButton
            // 
            this.DeleteRawButton.Location = new System.Drawing.Point(389, 535);
            this.DeleteRawButton.Name = "DeleteRawButton";
            this.DeleteRawButton.Size = new System.Drawing.Size(129, 48);
            this.DeleteRawButton.TabIndex = 6;
            this.DeleteRawButton.Text = "Удалить";
            this.DeleteRawButton.UseVisualStyleBackColor = true;
            this.DeleteRawButton.Click += new System.EventHandler(this.DeleteRawButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(665, 548);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(352, 22);
            this.SearchTextBox.TabIndex = 7;
            // 
            // SearchRawButton
            // 
            this.SearchRawButton.Location = new System.Drawing.Point(1072, 535);
            this.SearchRawButton.Name = "SearchRawButton";
            this.SearchRawButton.Size = new System.Drawing.Size(129, 48);
            this.SearchRawButton.TabIndex = 8;
            this.SearchRawButton.Text = "Поиск";
            this.SearchRawButton.UseVisualStyleBackColor = true;
            this.SearchRawButton.Click += new System.EventHandler(this.SearchRawButton_Click);
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
            this.id.HeaderText = "Код сырья";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Единица измерения";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Цена.Руб";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // discount
            // 
            this.discount.HeaderText = "Скидка";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 125;
            // 
            // idTypeOfRaw
            // 
            this.idTypeOfRaw.HeaderText = "Код вида сырья";
            this.idTypeOfRaw.MinimumWidth = 6;
            this.idTypeOfRaw.Name = "idTypeOfRaw";
            this.idTypeOfRaw.ReadOnly = true;
            this.idTypeOfRaw.Visible = false;
            this.idTypeOfRaw.Width = 125;
            // 
            // idTypeRaw
            // 
            this.idTypeRaw.HeaderText = "Код вида сырья";
            this.idTypeRaw.MinimumWidth = 6;
            this.idTypeRaw.Name = "idTypeRaw";
            this.idTypeRaw.ReadOnly = true;
            this.idTypeRaw.Visible = false;
            this.idTypeRaw.Width = 125;
            // 
            // typeName
            // 
            this.typeName.HeaderText = "Вид сырья";
            this.typeName.MinimumWidth = 6;
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            this.typeName.Width = 125;
            // 
            // RawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchRawButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteRawButton);
            this.Controls.Add(this.ChangeRawButton);
            this.Controls.Add(this.AddRawButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RawDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сырье";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RawForm_FormClosed);
            this.Load += new System.EventHandler(this.RawForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RawDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RawDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddRawButton;
        private System.Windows.Forms.Button ChangeRawButton;
        private System.Windows.Forms.Button DeleteRawButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchRawButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeOfRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
    }
}