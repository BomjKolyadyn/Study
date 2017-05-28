namespace Pr2ProgLang
{
    partial class fmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.Edit2 = new System.Windows.Forms.TextBox();
            this.Edit3 = new System.Windows.Forms.TextBox();
            this.Memo1 = new System.Windows.Forms.Label();
            this.Memo2 = new System.Windows.Forms.Label();
            this.Memo3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "&Файл";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(152, 22);
            this.menuFileExit.Text = "&Выход";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "&Справка";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.menuHelpAbout.Text = "&Об авторах";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // Edit1
            // 
            this.Edit1.Location = new System.Drawing.Point(12, 55);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(100, 20);
            this.Edit1.TabIndex = 1;
            this.Edit1.TextChanged += new System.EventHandler(this.Edit1_TextChanged);
            // 
            // Edit2
            // 
            this.Edit2.Location = new System.Drawing.Point(12, 109);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(100, 20);
            this.Edit2.TabIndex = 2;
            this.Edit2.TextChanged += new System.EventHandler(this.Edit2_TextChanged);
            // 
            // Edit3
            // 
            this.Edit3.Location = new System.Drawing.Point(12, 161);
            this.Edit3.Name = "Edit3";
            this.Edit3.Size = new System.Drawing.Size(100, 20);
            this.Edit3.TabIndex = 3;
            this.Edit3.TextChanged += new System.EventHandler(this.Edit3_TextChanged);
            // 
            // Memo1
            // 
            this.Memo1.AutoEllipsis = true;
            this.Memo1.Location = new System.Drawing.Point(9, 24);
            this.Memo1.Name = "Memo1";
            this.Memo1.Size = new System.Drawing.Size(158, 28);
            this.Memo1.TabIndex = 4;
            this.Memo1.Text = "Введите начальное значение отрезка интегрирования (а):";
            // 
            // Memo2
            // 
            this.Memo2.Location = new System.Drawing.Point(9, 78);
            this.Memo2.Name = "Memo2";
            this.Memo2.Size = new System.Drawing.Size(168, 28);
            this.Memo2.TabIndex = 5;
            this.Memo2.Text = "Введите конечное значение \r\nотрезка интегрирования(б):";
            // 
            // Memo3
            // 
            this.Memo3.AutoSize = true;
            this.Memo3.Location = new System.Drawing.Point(12, 132);
            this.Memo3.Name = "Memo3";
            this.Memo3.Size = new System.Drawing.Size(150, 26);
            this.Memo3.TabIndex = 6;
            this.Memo3.Text = "Введите значение точности \r\nинтрегрирования(eps):\r\n";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Memo3);
            this.Controls.Add(this.Memo2);
            this.Controls.Add(this.Memo1);
            this.Controls.Add(this.Edit3);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.TextBox Edit1;
        private System.Windows.Forms.TextBox Edit2;
        private System.Windows.Forms.TextBox Edit3;
        private System.Windows.Forms.Label Memo1;
        private System.Windows.Forms.Label Memo2;
        private System.Windows.Forms.Label Memo3;
    }
}

