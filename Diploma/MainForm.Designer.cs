namespace Diploma
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдатчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сырьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заготовительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемнаяКвитанцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.приемнаяКвитанцияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сдатчикToolStripMenuItem,
            this.сырьеToolStripMenuItem,
            this.заготовительToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // сдатчикToolStripMenuItem
            // 
            this.сдатчикToolStripMenuItem.Name = "сдатчикToolStripMenuItem";
            this.сдатчикToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.сдатчикToolStripMenuItem.Text = "Сдатчик";
            this.сдатчикToolStripMenuItem.Click += new System.EventHandler(this.сдатчикToolStripMenuItem_Click);
            // 
            // сырьеToolStripMenuItem
            // 
            this.сырьеToolStripMenuItem.Name = "сырьеToolStripMenuItem";
            this.сырьеToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.сырьеToolStripMenuItem.Text = "Сырье";
            this.сырьеToolStripMenuItem.Click += new System.EventHandler(this.сырьеToolStripMenuItem_Click);
            // 
            // заготовительToolStripMenuItem
            // 
            this.заготовительToolStripMenuItem.Name = "заготовительToolStripMenuItem";
            this.заготовительToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.заготовительToolStripMenuItem.Text = "Заготовитель";
            this.заготовительToolStripMenuItem.Click += new System.EventHandler(this.заготовительToolStripMenuItem_Click);
            // 
            // приемнаяКвитанцияToolStripMenuItem
            // 
            this.приемнаяКвитанцияToolStripMenuItem.Name = "приемнаяКвитанцияToolStripMenuItem";
            this.приемнаяКвитанцияToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.приемнаяКвитанцияToolStripMenuItem.Text = "Приемная квитанция";
            this.приемнаяКвитанцияToolStripMenuItem.Click += new System.EventHandler(this.приемнаяКвитанцияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 562);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдатчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сырьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заготовительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемнаяКвитанцияToolStripMenuItem;
    }
}

