namespace TextEditor
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utf8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utf16LEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utf16BEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.westernWindows1252ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.westernISO88591ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.westernISO88593ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.westernISO885915ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicWindows1256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicISO88596ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balticWindows1257ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balticISO88594ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralEuropeanWindows1250ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralEuropeanISO88592ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrillicWindows1251ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrillicISO88595ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrillicKOI8RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrillicKOI8UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.encodingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utf8ToolStripMenuItem,
            this.utf16LEToolStripMenuItem,
            this.utf16BEToolStripMenuItem,
            this.toolStripSeparator1,
            this.westernWindows1252ToolStripMenuItem,
            this.westernISO88591ToolStripMenuItem,
            this.westernISO88593ToolStripMenuItem,
            this.westernISO885915ToolStripMenuItem,
            this.arabicWindows1256ToolStripMenuItem,
            this.arabicISO88596ToolStripMenuItem,
            this.balticWindows1257ToolStripMenuItem,
            this.balticISO88594ToolStripMenuItem,
            this.centralEuropeanWindows1250ToolStripMenuItem,
            this.centralEuropeanISO88592ToolStripMenuItem,
            this.cyrillicWindows1251ToolStripMenuItem,
            this.cyrillicISO88595ToolStripMenuItem,
            this.cyrillicKOI8RToolStripMenuItem,
            this.cyrillicKOI8UToolStripMenuItem});
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encodingToolStripMenuItem.Text = "Кодировка";
            // 
            // utf8ToolStripMenuItem
            // 
            this.utf8ToolStripMenuItem.Name = "utf8ToolStripMenuItem";
            this.utf8ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.utf8ToolStripMenuItem.Text = "UTF-8";
            this.utf8ToolStripMenuItem.Click += new System.EventHandler(this.utf8ToolStripMenuItem_Click);
            // 
            // utf16LEToolStripMenuItem
            // 
            this.utf16LEToolStripMenuItem.Name = "utf16LEToolStripMenuItem";
            this.utf16LEToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.utf16LEToolStripMenuItem.Text = "UTF-16 LE";
            this.utf16LEToolStripMenuItem.Click += new System.EventHandler(this.utf16LEToolStripMenuItem_Click);
            // 
            // utf16BEToolStripMenuItem
            // 
            this.utf16BEToolStripMenuItem.Name = "utf16BEToolStripMenuItem";
            this.utf16BEToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.utf16BEToolStripMenuItem.Text = "UTF-16 BE";
            this.utf16BEToolStripMenuItem.Click += new System.EventHandler(this.utf16BEToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // westernWindows1252ToolStripMenuItem
            // 
            this.westernWindows1252ToolStripMenuItem.Name = "westernWindows1252ToolStripMenuItem";
            this.westernWindows1252ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.westernWindows1252ToolStripMenuItem.Text = "Western (Windows 1252)";
            this.westernWindows1252ToolStripMenuItem.Click += new System.EventHandler(this.westernWindows1252ToolStripMenuItem_Click);
            // 
            // westernISO88591ToolStripMenuItem
            // 
            this.westernISO88591ToolStripMenuItem.Name = "westernISO88591ToolStripMenuItem";
            this.westernISO88591ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.westernISO88591ToolStripMenuItem.Text = "Western (ISO 8859-1)";
            this.westernISO88591ToolStripMenuItem.Click += new System.EventHandler(this.westernISO88591ToolStripMenuItem_Click);
            // 
            // westernISO88593ToolStripMenuItem
            // 
            this.westernISO88593ToolStripMenuItem.Name = "westernISO88593ToolStripMenuItem";
            this.westernISO88593ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.westernISO88593ToolStripMenuItem.Text = "Western (ISO 8859-3)";
            this.westernISO88593ToolStripMenuItem.Click += new System.EventHandler(this.westernISO88593ToolStripMenuItem_Click);
            // 
            // westernISO885915ToolStripMenuItem
            // 
            this.westernISO885915ToolStripMenuItem.Name = "westernISO885915ToolStripMenuItem";
            this.westernISO885915ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.westernISO885915ToolStripMenuItem.Text = "Western (ISO 8859-15)";
            this.westernISO885915ToolStripMenuItem.Click += new System.EventHandler(this.westernISO885915ToolStripMenuItem_Click);
            // 
            // arabicWindows1256ToolStripMenuItem
            // 
            this.arabicWindows1256ToolStripMenuItem.Name = "arabicWindows1256ToolStripMenuItem";
            this.arabicWindows1256ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.arabicWindows1256ToolStripMenuItem.Text = "Arabic (Windows 1256)";
            this.arabicWindows1256ToolStripMenuItem.Click += new System.EventHandler(this.arabicWindows1256ToolStripMenuItem_Click);
            // 
            // arabicISO88596ToolStripMenuItem
            // 
            this.arabicISO88596ToolStripMenuItem.Name = "arabicISO88596ToolStripMenuItem";
            this.arabicISO88596ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.arabicISO88596ToolStripMenuItem.Text = "Arabic (ISO 8859-6)";
            this.arabicISO88596ToolStripMenuItem.Click += new System.EventHandler(this.arabicISO88596ToolStripMenuItem_Click);
            // 
            // balticWindows1257ToolStripMenuItem
            // 
            this.balticWindows1257ToolStripMenuItem.Name = "balticWindows1257ToolStripMenuItem";
            this.balticWindows1257ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.balticWindows1257ToolStripMenuItem.Text = "Baltic (Windows 1257)";
            this.balticWindows1257ToolStripMenuItem.Click += new System.EventHandler(this.balticWindows1257ToolStripMenuItem_Click);
            // 
            // balticISO88594ToolStripMenuItem
            // 
            this.balticISO88594ToolStripMenuItem.Name = "balticISO88594ToolStripMenuItem";
            this.balticISO88594ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.balticISO88594ToolStripMenuItem.Text = "Baltic (ISO 8859-4)";
            this.balticISO88594ToolStripMenuItem.Click += new System.EventHandler(this.balticISO88594ToolStripMenuItem_Click);
            // 
            // centralEuropeanWindows1250ToolStripMenuItem
            // 
            this.centralEuropeanWindows1250ToolStripMenuItem.Name = "centralEuropeanWindows1250ToolStripMenuItem";
            this.centralEuropeanWindows1250ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.centralEuropeanWindows1250ToolStripMenuItem.Text = "Central European (Windows 1250)";
            this.centralEuropeanWindows1250ToolStripMenuItem.Click += new System.EventHandler(this.centralEuropeanWindows1250ToolStripMenuItem_Click);
            // 
            // centralEuropeanISO88592ToolStripMenuItem
            // 
            this.centralEuropeanISO88592ToolStripMenuItem.Name = "centralEuropeanISO88592ToolStripMenuItem";
            this.centralEuropeanISO88592ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.centralEuropeanISO88592ToolStripMenuItem.Text = "Central European (ISO 8859-2)";
            this.centralEuropeanISO88592ToolStripMenuItem.Click += new System.EventHandler(this.centralEuropeanISO88592ToolStripMenuItem_Click);
            // 
            // cyrillicWindows1251ToolStripMenuItem
            // 
            this.cyrillicWindows1251ToolStripMenuItem.Name = "cyrillicWindows1251ToolStripMenuItem";
            this.cyrillicWindows1251ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cyrillicWindows1251ToolStripMenuItem.Text = "Cyrillic (Windows 1251)";
            this.cyrillicWindows1251ToolStripMenuItem.Click += new System.EventHandler(this.cyrillicWindows1251ToolStripMenuItem_Click);
            // 
            // cyrillicISO88595ToolStripMenuItem
            // 
            this.cyrillicISO88595ToolStripMenuItem.Name = "cyrillicISO88595ToolStripMenuItem";
            this.cyrillicISO88595ToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cyrillicISO88595ToolStripMenuItem.Text = "Cyrillic (ISO 8859-5)";
            this.cyrillicISO88595ToolStripMenuItem.Click += new System.EventHandler(this.cyrillicISO88595ToolStripMenuItem_Click);
            // 
            // cyrillicKOI8RToolStripMenuItem
            // 
            this.cyrillicKOI8RToolStripMenuItem.Name = "cyrillicKOI8RToolStripMenuItem";
            this.cyrillicKOI8RToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cyrillicKOI8RToolStripMenuItem.Text = "Cyrillic (KOI8-R)";
            this.cyrillicKOI8RToolStripMenuItem.Click += new System.EventHandler(this.cyrillicKOI8RToolStripMenuItem_Click);
            // 
            // cyrillicKOI8UToolStripMenuItem
            // 
            this.cyrillicKOI8UToolStripMenuItem.Name = "cyrillicKOI8UToolStripMenuItem";
            this.cyrillicKOI8UToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.cyrillicKOI8UToolStripMenuItem.Text = "Cyrillic (KOI8-U)";
            this.cyrillicKOI8UToolStripMenuItem.Click += new System.EventHandler(this.cyrillicKOI8UToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 426);
            this.textBox.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "TextEditor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utf8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utf16LEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utf16BEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem westernWindows1252ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem westernISO88591ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem westernISO88593ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem westernISO885915ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicWindows1256ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicISO88596ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balticWindows1257ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balticISO88594ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralEuropeanWindows1250ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralEuropeanISO88592ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicWindows1251ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicISO88595ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicKOI8RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicKOI8UToolStripMenuItem;
    }
}

