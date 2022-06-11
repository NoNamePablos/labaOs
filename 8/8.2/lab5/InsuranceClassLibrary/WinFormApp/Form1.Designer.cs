
namespace WinFormApp
{
    partial class FormMain
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
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XmlLoadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.JsonLoadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BinloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.филиалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видыСтрахованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlInsTypes = new System.Windows.Forms.TabControl();
            this.tabPageDepartament = new System.Windows.Forms.TabPage();
            this.ListViewDepartamnet = new System.Windows.Forms.ListView();
            this.NameDep = new System.Windows.Forms.ColumnHeader();
            this.AddressDep = new System.Windows.Forms.ColumnHeader();
            this.telDep = new System.Windows.Forms.ColumnHeader();
            this.tabPageTypesInsurance = new System.Windows.Forms.TabPage();
            this.listViewTypes = new System.Windows.Forms.ListView();
            this.TypesInsurance = new System.Windows.Forms.ColumnHeader();
            this.tabPageContract = new System.Windows.Forms.TabPage();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControlInsTypes.SuspendLayout();
            this.tabPageDepartament.SuspendLayout();
            this.tabPageTypesInsurance.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.филиалToolStripMenuItem,
            this.ContractToolStripMenuItem,
            this.видыСтрахованияToolStripMenuItem,
            this.полнаяИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.binToolStripMenuItem});
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.XmlSaveToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.JsonSaveToolStripMenuItem_Click);
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.BinSaveToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XmlLoadToolStripMenuItem1,
            this.JsonLoadToolStripMenuItem1,
            this.BinloadToolStripMenuItem1});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // XmlLoadToolStripMenuItem1
            // 
            this.XmlLoadToolStripMenuItem1.Name = "XmlLoadToolStripMenuItem1";
            this.XmlLoadToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.XmlLoadToolStripMenuItem1.Text = "XML";
            this.XmlLoadToolStripMenuItem1.Click += new System.EventHandler(this.XmlLoadToolStripMenuItem1_Click);
            // 
            // JsonLoadToolStripMenuItem1
            // 
            this.JsonLoadToolStripMenuItem1.Name = "JsonLoadToolStripMenuItem1";
            this.JsonLoadToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.JsonLoadToolStripMenuItem1.Text = "JSON";
            this.JsonLoadToolStripMenuItem1.Click += new System.EventHandler(this.JsonLoadToolStripMenuItem1_Click);
            // 
            // BinloadToolStripMenuItem1
            // 
            this.BinloadToolStripMenuItem1.Name = "BinloadToolStripMenuItem1";
            this.BinloadToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.BinloadToolStripMenuItem1.Text = "Bin";
            this.BinloadToolStripMenuItem1.Click += new System.EventHandler(this.BinloadToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // филиалToolStripMenuItem
            // 
            this.филиалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.филиалToolStripMenuItem.Name = "филиалToolStripMenuItem";
            this.филиалToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.филиалToolStripMenuItem.Text = "Филиал";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemDepartament_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItemDep_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ContractToolStripMenuItem.Text = "Контракт";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem1.Text = "Добавить";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItemContract_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem1.Text = "Редактировать";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItemContract_Click);
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
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemInsTypes_Click_1);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItemInsType_Click);
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
            // tabControlInsTypes
            // 
            this.tabControlInsTypes.Controls.Add(this.tabPageDepartament);
            this.tabControlInsTypes.Controls.Add(this.tabPageTypesInsurance);
            this.tabControlInsTypes.Controls.Add(this.tabPageContract);
            this.tabControlInsTypes.Location = new System.Drawing.Point(0, 27);
            this.tabControlInsTypes.Name = "tabControlInsTypes";
            this.tabControlInsTypes.SelectedIndex = 0;
            this.tabControlInsTypes.Size = new System.Drawing.Size(800, 422);
            this.tabControlInsTypes.TabIndex = 1;
            // 
            // tabPageDepartament
            // 
            this.tabPageDepartament.Controls.Add(this.ListViewDepartamnet);
            this.tabPageDepartament.Location = new System.Drawing.Point(4, 24);
            this.tabPageDepartament.Name = "tabPageDepartament";
            this.tabPageDepartament.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartament.Size = new System.Drawing.Size(792, 394);
            this.tabPageDepartament.TabIndex = 0;
            this.tabPageDepartament.Text = "Филиал";
            this.tabPageDepartament.UseVisualStyleBackColor = true;
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
            // tabPageTypesInsurance
            // 
            this.tabPageTypesInsurance.Controls.Add(this.listViewTypes);
            this.tabPageTypesInsurance.Location = new System.Drawing.Point(4, 24);
            this.tabPageTypesInsurance.Name = "tabPageTypesInsurance";
            this.tabPageTypesInsurance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypesInsurance.Size = new System.Drawing.Size(792, 394);
            this.tabPageTypesInsurance.TabIndex = 1;
            this.tabPageTypesInsurance.Text = "Виды Страхования";
            this.tabPageTypesInsurance.UseVisualStyleBackColor = true;
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
            // tabPageContract
            // 
            this.tabPageContract.Location = new System.Drawing.Point(4, 24);
            this.tabPageContract.Name = "tabPageContract";
            this.tabPageContract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContract.Size = new System.Drawing.Size(792, 394);
            this.tabPageContract.TabIndex = 2;
            this.tabPageContract.Text = "Контракт";
            this.tabPageContract.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.tabControlInsTypes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Страховая компания \"У сосседа лучше\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlInsTypes.ResumeLayout(false);
            this.tabPageDepartament.ResumeLayout(false);
            this.tabPageTypesInsurance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem филиалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видыСтрахованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem2;
        private System.Windows.Forms.TabControl tabControlInsTypes;
        private System.Windows.Forms.TabPage tabPageDepartament;
        private System.Windows.Forms.ListView ListViewDepartamnet;
        private System.Windows.Forms.TabPage tabPageTypesInsurance;
        private System.Windows.Forms.TabPage tabPageContract;
        private System.Windows.Forms.ColumnHeader NameDep;
        private System.Windows.Forms.ColumnHeader AddressDep;
        private System.Windows.Forms.ColumnHeader telDep;
        private System.Windows.Forms.ListView listViewTypes;
        private System.Windows.Forms.ColumnHeader TypesInsurance;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XmlLoadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem JsonLoadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BinloadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

