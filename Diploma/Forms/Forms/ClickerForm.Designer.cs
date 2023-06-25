namespace Diploma.Forms
{
    partial class ClickerForm
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
            this.ClickerDataGrid = new System.Windows.Forms.DataGridView();
            this.idClicker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClicker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameClicker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicClicker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRaysouyz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRaysouyz2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRaysoyuz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClickerButton = new System.Windows.Forms.Button();
            this.ChangeClickerButton = new System.Windows.Forms.Button();
            this.DeleteClickerButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchClickerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClickerDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClickerDataGrid
            // 
            this.ClickerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClickerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClicker,
            this.nameClicker,
            this.surnameClicker,
            this.patronymicClicker,
            this.idRaysouyz,
            this.idRaysouyz2,
            this.nameRaysoyuz,
            this.idRegion,
            this.idRegion2,
            this.nameRegion});
            this.ClickerDataGrid.Location = new System.Drawing.Point(12, 87);
            this.ClickerDataGrid.Name = "ClickerDataGrid";
            this.ClickerDataGrid.ReadOnly = true;
            this.ClickerDataGrid.RowHeadersWidth = 51;
            this.ClickerDataGrid.RowTemplate.Height = 24;
            this.ClickerDataGrid.Size = new System.Drawing.Size(960, 406);
            this.ClickerDataGrid.TabIndex = 0;
            // 
            // idClicker
            // 
            this.idClicker.HeaderText = "Код заготовщика";
            this.idClicker.MinimumWidth = 6;
            this.idClicker.Name = "idClicker";
            this.idClicker.ReadOnly = true;
            this.idClicker.Visible = false;
            this.idClicker.Width = 125;
            // 
            // nameClicker
            // 
            this.nameClicker.HeaderText = "Имя";
            this.nameClicker.MinimumWidth = 6;
            this.nameClicker.Name = "nameClicker";
            this.nameClicker.ReadOnly = true;
            this.nameClicker.Width = 125;
            // 
            // surnameClicker
            // 
            this.surnameClicker.HeaderText = "Фамилия";
            this.surnameClicker.MinimumWidth = 6;
            this.surnameClicker.Name = "surnameClicker";
            this.surnameClicker.ReadOnly = true;
            this.surnameClicker.Width = 125;
            // 
            // patronymicClicker
            // 
            this.patronymicClicker.HeaderText = "Отчество";
            this.patronymicClicker.MinimumWidth = 6;
            this.patronymicClicker.Name = "patronymicClicker";
            this.patronymicClicker.ReadOnly = true;
            this.patronymicClicker.Width = 125;
            // 
            // idRaysouyz
            // 
            this.idRaysouyz.HeaderText = "Код райсоюза";
            this.idRaysouyz.MinimumWidth = 6;
            this.idRaysouyz.Name = "idRaysouyz";
            this.idRaysouyz.ReadOnly = true;
            this.idRaysouyz.Visible = false;
            this.idRaysouyz.Width = 125;
            // 
            // idRaysouyz2
            // 
            this.idRaysouyz2.HeaderText = "Код райсоюза";
            this.idRaysouyz2.MinimumWidth = 6;
            this.idRaysouyz2.Name = "idRaysouyz2";
            this.idRaysouyz2.ReadOnly = true;
            this.idRaysouyz2.Visible = false;
            this.idRaysouyz2.Width = 125;
            // 
            // nameRaysoyuz
            // 
            this.nameRaysoyuz.HeaderText = "Название райсоюза";
            this.nameRaysoyuz.MinimumWidth = 6;
            this.nameRaysoyuz.Name = "nameRaysoyuz";
            this.nameRaysoyuz.ReadOnly = true;
            this.nameRaysoyuz.Width = 125;
            // 
            // idRegion
            // 
            this.idRegion.HeaderText = "Код области";
            this.idRegion.MinimumWidth = 6;
            this.idRegion.Name = "idRegion";
            this.idRegion.ReadOnly = true;
            this.idRegion.Visible = false;
            this.idRegion.Width = 125;
            // 
            // idRegion2
            // 
            this.idRegion2.HeaderText = "Код области";
            this.idRegion2.MinimumWidth = 6;
            this.idRegion2.Name = "idRegion2";
            this.idRegion2.ReadOnly = true;
            this.idRegion2.Visible = false;
            this.idRegion2.Width = 125;
            // 
            // nameRegion
            // 
            this.nameRegion.HeaderText = "Название области";
            this.nameRegion.MinimumWidth = 6;
            this.nameRegion.Name = "nameRegion";
            this.nameRegion.ReadOnly = true;
            this.nameRegion.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заготовщики";
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
            this.checkBox1.Size = new System.Drawing.Size(167, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Имя по возрастанию";
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
            // AddClickerButton
            // 
            this.AddClickerButton.Location = new System.Drawing.Point(12, 535);
            this.AddClickerButton.Name = "AddClickerButton";
            this.AddClickerButton.Size = new System.Drawing.Size(129, 48);
            this.AddClickerButton.TabIndex = 4;
            this.AddClickerButton.Text = "Добавить";
            this.AddClickerButton.UseVisualStyleBackColor = true;
            this.AddClickerButton.Click += new System.EventHandler(this.AddClickerButton_Click);
            // 
            // ChangeClickerButton
            // 
            this.ChangeClickerButton.Location = new System.Drawing.Point(192, 535);
            this.ChangeClickerButton.Name = "ChangeClickerButton";
            this.ChangeClickerButton.Size = new System.Drawing.Size(129, 48);
            this.ChangeClickerButton.TabIndex = 5;
            this.ChangeClickerButton.Text = "Изменить";
            this.ChangeClickerButton.UseVisualStyleBackColor = true;
            this.ChangeClickerButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteClickerButton
            // 
            this.DeleteClickerButton.Location = new System.Drawing.Point(389, 535);
            this.DeleteClickerButton.Name = "DeleteClickerButton";
            this.DeleteClickerButton.Size = new System.Drawing.Size(129, 48);
            this.DeleteClickerButton.TabIndex = 6;
            this.DeleteClickerButton.Text = "Удалить";
            this.DeleteClickerButton.UseVisualStyleBackColor = true;
            this.DeleteClickerButton.Click += new System.EventHandler(this.DeleteClickerButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(665, 548);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(352, 22);
            this.SearchTextBox.TabIndex = 7;
            // 
            // SearchClickerButton
            // 
            this.SearchClickerButton.Location = new System.Drawing.Point(1072, 535);
            this.SearchClickerButton.Name = "SearchClickerButton";
            this.SearchClickerButton.Size = new System.Drawing.Size(129, 48);
            this.SearchClickerButton.TabIndex = 8;
            this.SearchClickerButton.Text = "Поиск";
            this.SearchClickerButton.UseVisualStyleBackColor = true;
            this.SearchClickerButton.Click += new System.EventHandler(this.SearchClickerButton_Click);
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
            // ClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchClickerButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteClickerButton);
            this.Controls.Add(this.ChangeClickerButton);
            this.Controls.Add(this.AddClickerButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClickerDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заготовщик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClickerForm_FormClosed);
            this.Load += new System.EventHandler(this.ClickerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClickerDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClickerDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddClickerButton;
        private System.Windows.Forms.Button ChangeClickerButton;
        private System.Windows.Forms.Button DeleteClickerButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchClickerButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameClicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicClicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRaysouyz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRaysouyz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameRaysoyuz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameRegion;
    }
}