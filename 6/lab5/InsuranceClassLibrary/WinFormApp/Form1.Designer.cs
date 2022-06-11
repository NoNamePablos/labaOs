
namespace WinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.филиалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видыСтрахованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListViewDepartamnet = new System.Windows.Forms.ListView();
            this.NameDep = new System.Windows.Forms.ColumnHeader();
            this.AddressDep = new System.Windows.Forms.ColumnHeader();
            this.telDep = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewTypes = new System.Windows.Forms.ListView();
            this.TypesInsurance = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewContracts = new System.Windows.Forms.ListView();
            this.NumberContract = new System.Windows.Forms.ColumnHeader();
            this.dateContaract = new System.Windows.Forms.ColumnHeader();
            this.insuranceAmount = new System.Windows.Forms.ColumnHeader();
            this.tariffRate = new System.Windows.Forms.ColumnHeader();
            this.depContract = new System.Windows.Forms.ColumnHeader();
            this.typeInsuracnce = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.филиалToolStripMenuItem,
            this.контрактToolStripMenuItem,
            this.видыСтрахованияToolStripMenuItem,
            this.полнаяИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // филиалToolStripMenuItem
            // 
            this.филиалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.филиалToolStripMenuItem.Name = "филиалToolStripMenuItem";
            this.филиалToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.филиалToolStripMenuItem.Text = "Филиал";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // контрактToolStripMenuItem
            // 
            this.контрактToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.контрактToolStripMenuItem.Name = "контрактToolStripMenuItem";
            this.контрактToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.контрактToolStripMenuItem.Text = "Контракт";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem1.Text = "Добавить";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem1.Text = "Редактировать";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // видыСтрахованияToolStripMenuItem
            // 
            this.видыСтрахованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem1});
            this.видыСтрахованияToolStripMenuItem.Name = "видыСтрахованияToolStripMenuItem";
            this.видыСтрахованияToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.видыСтрахованияToolStripMenuItem.Text = "Виды страхования";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click_1);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // полнаяИнформацияToolStripMenuItem
            // 
            this.полнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem2});
            this.полнаяИнформацияToolStripMenuItem.Name = "полнаяИнформацияToolStripMenuItem";
            this.полнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.полнаяИнформацияToolStripMenuItem.Text = "Полная информация";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // редактироватьToolStripMenuItem2
            // 
            this.редактироватьToolStripMenuItem2.Name = "редактироватьToolStripMenuItem2";
            this.редактироватьToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem2.Text = "Редактировать";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListViewDepartamnet);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Филиал";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListViewDepartamnet
            // 
            this.ListViewDepartamnet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameDep,
            this.AddressDep,
            this.telDep});
            this.ListViewDepartamnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewDepartamnet.FullRowSelect = true;
            this.ListViewDepartamnet.GridLines = true;
            this.ListViewDepartamnet.HideSelection = false;
            this.ListViewDepartamnet.Location = new System.Drawing.Point(3, 3);
            this.ListViewDepartamnet.Name = "ListViewDepartamnet";
            this.ListViewDepartamnet.Size = new System.Drawing.Size(786, 388);
            this.ListViewDepartamnet.TabIndex = 1;
            this.ListViewDepartamnet.UseCompatibleStateImageBehavior = false;
            this.ListViewDepartamnet.View = System.Windows.Forms.View.Details;
            this.ListViewDepartamnet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewDepartamnet_KeyUp);
            // 
            // NameDep
            // 
            this.NameDep.Text = "Филиал";
            this.NameDep.Width = 150;
            // 
            // AddressDep
            // 
            this.AddressDep.Text = "Адрес Филиала";
            this.AddressDep.Width = 150;
            // 
            // telDep
            // 
            this.telDep.Text = "Телефон";
            this.telDep.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewTypes);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Виды Страхования";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewTypes
            // 
            this.listViewTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypesInsurance});
            this.listViewTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTypes.FullRowSelect = true;
            this.listViewTypes.GridLines = true;
            this.listViewTypes.HideSelection = false;
            this.listViewTypes.Location = new System.Drawing.Point(3, 3);
            this.listViewTypes.Name = "listViewTypes";
            this.listViewTypes.Size = new System.Drawing.Size(786, 388);
            this.listViewTypes.TabIndex = 2;
            this.listViewTypes.UseCompatibleStateImageBehavior = false;
            this.listViewTypes.View = System.Windows.Forms.View.Details;
            this.listViewTypes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewTypes_KeyUp);
            // 
            // TypesInsurance
            // 
            this.TypesInsurance.Text = "Типы страхования";
            this.TypesInsurance.Width = 600;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewContracts);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Контракт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewContracts
            // 
            this.listViewContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberContract,
            this.dateContaract,
            this.insuranceAmount,
            this.tariffRate,
            this.depContract,
            this.typeInsuracnce});
            this.listViewContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContracts.FullRowSelect = true;
            this.listViewContracts.GridLines = true;
            this.listViewContracts.HideSelection = false;
            this.listViewContracts.Location = new System.Drawing.Point(3, 3);
            this.listViewContracts.Name = "listViewContracts";
            this.listViewContracts.Size = new System.Drawing.Size(786, 388);
            this.listViewContracts.TabIndex = 2;
            this.listViewContracts.UseCompatibleStateImageBehavior = false;
            this.listViewContracts.View = System.Windows.Forms.View.Details;
            this.listViewContracts.SelectedIndexChanged += new System.EventHandler(this.listViewContracts_SelectedIndexChanged);
            this.listViewContracts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewContracts_KeyUp);
            // 
            // NumberContract
            // 
            this.NumberContract.Text = "№ Договора";
            // 
            // dateContaract
            // 
            this.dateContaract.Text = "Дата сделки";
            this.dateContaract.Width = 150;
            // 
            // insuranceAmount
            // 
            this.insuranceAmount.Text = "Страховая сумма";
            this.insuranceAmount.Width = 150;
            // 
            // tariffRate
            // 
            this.tariffRate.Text = "Тарифная ставка";
            this.tariffRate.Width = 150;
            // 
            // depContract
            // 
            this.depContract.Text = "Филиал";
            this.depContract.Width = 150;
            // 
            // typeInsuracnce
            // 
            this.typeInsuracnce.Text = "Тип страхования";
            this.typeInsuracnce.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem филиалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыСтрахованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView ListViewDepartamnet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader NameDep;
        private System.Windows.Forms.ColumnHeader AddressDep;
        private System.Windows.Forms.ColumnHeader telDep;
        private System.Windows.Forms.ListView listViewTypes;
        private System.Windows.Forms.ColumnHeader TypesInsurance;
        private System.Windows.Forms.ListView listViewContracts;
        private System.Windows.Forms.ColumnHeader NumberContract;
        private System.Windows.Forms.ColumnHeader dateContaract;
        private System.Windows.Forms.ColumnHeader insuranceAmount;
        private System.Windows.Forms.ColumnHeader tariffRate;
        private System.Windows.Forms.ColumnHeader depContract;
        private System.Windows.Forms.ColumnHeader typeInsuracnce;
    }
}

