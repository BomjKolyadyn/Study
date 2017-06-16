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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIter = new System.Windows.Forms.Button();
            this.EditIter = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.EditS = new System.Windows.Forms.TextBox();
            this.btnS2 = new System.Windows.Forms.Button();
            this.EditS2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
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
            this.menuFileExit.Size = new System.Drawing.Size(108, 22);
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
            this.menuHelpAbout.Size = new System.Drawing.Size(135, 22);
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
            this.Memo1.Click += new System.EventHandler(this.Memo1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Определенный интеграл равен :\r\n";
            // 
            // Edit4
            // 
            this.Edit4.Location = new System.Drawing.Point(12, 268);
            this.Edit4.Name = "Edit4";
            this.Edit4.Size = new System.Drawing.Size(100, 20);
            this.Edit4.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(189, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 264);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pr2ProgLang.Properties.Resources.Screenshot_5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIter
            // 
            this.btnIter.Location = new System.Drawing.Point(479, 55);
            this.btnIter.Name = "btnIter";
            this.btnIter.Size = new System.Drawing.Size(75, 23);
            this.btnIter.TabIndex = 13;
            this.btnIter.Text = "Итерации\r\n";
            this.btnIter.UseVisualStyleBackColor = true;
            this.btnIter.Click += new System.EventHandler(this.btnIter_Click);
            // 
            // EditIter
            // 
            this.EditIter.Location = new System.Drawing.Point(560, 58);
            this.EditIter.Name = "EditIter";
            this.EditIter.Size = new System.Drawing.Size(75, 20);
            this.EditIter.TabIndex = 14;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(479, 106);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 15;
            this.btnS.Text = "S1";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // EditS
            // 
            this.EditS.Location = new System.Drawing.Point(560, 106);
            this.EditS.Name = "EditS";
            this.EditS.Size = new System.Drawing.Size(75, 20);
            this.EditS.TabIndex = 16;
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(479, 135);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(75, 23);
            this.btnS2.TabIndex = 17;
            this.btnS2.Text = "S2";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // EditS2
            // 
            this.EditS2.Location = new System.Drawing.Point(561, 137);
            this.EditS2.Name = "EditS2";
            this.EditS2.Size = new System.Drawing.Size(74, 20);
            this.EditS2.TabIndex = 18;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 301);
            this.Controls.Add(this.EditS2);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.EditS);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.EditIter);
            this.Controls.Add(this.btnIter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edit4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Memo3);
            this.Controls.Add(this.Memo2);
            this.Controls.Add(this.Memo1);
            this.Controls.Add(this.Edit3);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "fmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Edit4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIter;
        private System.Windows.Forms.TextBox EditIter;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox EditS;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.TextBox EditS2;
    }
}

