namespace Lab12
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label continentLabel;
            System.Windows.Forms.Label photoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageContinent = new System.Windows.Forms.TabPage();
            this.continentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.continentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryDBDataSet = new Lab12.CountryDBDataSet();
            this.continentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.continentBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.continentBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.continentBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.continentBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.continentBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.continentBindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.continentBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.continentBindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.continentBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.continentBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.continentBindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.continentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageCountry = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.countryDataGridView = new System.Windows.Forms.DataGridView();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.countryBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.countryBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.countryBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.countryBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.countryBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.countryBindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.countryBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.countryBindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.countryBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.countryBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.countryBindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.id_continentComboBox = new System.Windows.Forms.ComboBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStripPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.continentTableAdapter = new Lab12.CountryDBDataSetTableAdapters.continentTableAdapter();
            this.tableAdapterManager = new Lab12.CountryDBDataSetTableAdapters.TableAdapterManager();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.countryTableAdapter = new Lab12.CountryDBDataSetTableAdapters.countryTableAdapter();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            continentLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageContinent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingNavigator)).BeginInit();
            this.continentBindingNavigator.SuspendLayout();
            this.tabPageCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingNavigator)).BeginInit();
            this.countryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.contextMenuStripPhoto.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 10;
            idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 36);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Название:";
            // 
            // continentLabel
            // 
            continentLabel.AutoSize = true;
            continentLabel.Location = new System.Drawing.Point(3, 62);
            continentLabel.Name = "continentLabel";
            continentLabel.Size = new System.Drawing.Size(63, 13);
            continentLabel.TabIndex = 14;
            continentLabel.Text = "Континент:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(3, 93);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(80, 13);
            photoLabel.TabIndex = 16;
            photoLabel.Text = "Изображение:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.printToolStripMenuItem.Text = "Печать";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageContinent);
            this.tabControl.Controls.Add(this.tabPageCountry);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 426);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageContinent
            // 
            this.tabPageContinent.Controls.Add(this.continentDataGridView);
            this.tabPageContinent.Controls.Add(this.continentBindingNavigator);
            this.tabPageContinent.Location = new System.Drawing.Point(4, 22);
            this.tabPageContinent.Name = "tabPageContinent";
            this.tabPageContinent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContinent.Size = new System.Drawing.Size(792, 400);
            this.tabPageContinent.TabIndex = 0;
            this.tabPageContinent.Text = "Страна";
            this.tabPageContinent.UseVisualStyleBackColor = true;
            // 
            // continentDataGridView
            // 
            this.continentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.continentDataGridView.AutoGenerateColumns = false;
            this.continentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.continentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.continentDataGridView.DataSource = this.continentBindingSource;
            this.continentDataGridView.Location = new System.Drawing.Point(8, 31);
            this.continentDataGridView.Name = "continentDataGridView";
            this.continentDataGridView.Size = new System.Drawing.Size(764, 363);
            this.continentDataGridView.TabIndex = 0;
            this.continentDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.continentDataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // continentBindingSource
            // 
            this.continentBindingSource.DataMember = "continent";
            this.continentBindingSource.DataSource = this.countryDBDataSet;
            // 
            // countryDBDataSet
            // 
            this.countryDBDataSet.DataSetName = "CountryDBDataSet";
            this.countryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // continentBindingNavigator
            // 
            this.continentBindingNavigator.AddNewItem = this.continentBindingNavigatorAddNewItem;
            this.continentBindingNavigator.BindingSource = this.continentBindingSource;
            this.continentBindingNavigator.CountItem = this.continentBindingNavigatorCountItem;
            this.continentBindingNavigator.DeleteItem = this.continentBindingNavigatorDeleteItem;
            this.continentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continentBindingNavigatorMoveFirstItem,
            this.continentBindingNavigatorMovePreviousItem,
            this.continentBindingNavigatorSeparator,
            this.continentBindingNavigatorPositionItem,
            this.continentBindingNavigatorCountItem,
            this.continentBindingNavigatorSeparator1,
            this.continentBindingNavigatorMoveNextItem,
            this.continentBindingNavigatorMoveLastItem,
            this.continentBindingNavigatorSeparator2,
            this.continentBindingNavigatorAddNewItem,
            this.continentBindingNavigatorDeleteItem,
            this.continentBindingNavigatorSaveItem});
            this.continentBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.continentBindingNavigator.MoveFirstItem = this.continentBindingNavigatorMoveFirstItem;
            this.continentBindingNavigator.MoveLastItem = this.continentBindingNavigatorMoveLastItem;
            this.continentBindingNavigator.MoveNextItem = this.continentBindingNavigatorMoveNextItem;
            this.continentBindingNavigator.MovePreviousItem = this.continentBindingNavigatorMovePreviousItem;
            this.continentBindingNavigator.Name = "continentBindingNavigator";
            this.continentBindingNavigator.PositionItem = this.continentBindingNavigatorPositionItem;
            this.continentBindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.continentBindingNavigator.TabIndex = 3;
            this.continentBindingNavigator.Text = "bindingNavigator1";
            // 
            // continentBindingNavigatorAddNewItem
            // 
            this.continentBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorAddNewItem.Image")));
            this.continentBindingNavigatorAddNewItem.Name = "continentBindingNavigatorAddNewItem";
            this.continentBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.continentBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorAddNewItem.Text = "Add new";
            this.continentBindingNavigatorAddNewItem.Click += new System.EventHandler(this.continentBindingNavigatorAddNewItem_Click);
            // 
            // continentBindingNavigatorCountItem
            // 
            this.continentBindingNavigatorCountItem.Name = "continentBindingNavigatorCountItem";
            this.continentBindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.continentBindingNavigatorCountItem.Text = "для {0}";
            this.continentBindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // continentBindingNavigatorDeleteItem
            // 
            this.continentBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorDeleteItem.Image")));
            this.continentBindingNavigatorDeleteItem.Name = "continentBindingNavigatorDeleteItem";
            this.continentBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.continentBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorDeleteItem.Text = "Delete";
            // 
            // continentBindingNavigatorMoveFirstItem
            // 
            this.continentBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorMoveFirstItem.Image")));
            this.continentBindingNavigatorMoveFirstItem.Name = "continentBindingNavigatorMoveFirstItem";
            this.continentBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.continentBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // continentBindingNavigatorMovePreviousItem
            // 
            this.continentBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorMovePreviousItem.Image")));
            this.continentBindingNavigatorMovePreviousItem.Name = "continentBindingNavigatorMovePreviousItem";
            this.continentBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.continentBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // continentBindingNavigatorSeparator
            // 
            this.continentBindingNavigatorSeparator.Name = "continentBindingNavigatorSeparator";
            this.continentBindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // continentBindingNavigatorPositionItem
            // 
            this.continentBindingNavigatorPositionItem.AccessibleName = "Position";
            this.continentBindingNavigatorPositionItem.AutoSize = false;
            this.continentBindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.continentBindingNavigatorPositionItem.Name = "continentBindingNavigatorPositionItem";
            this.continentBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.continentBindingNavigatorPositionItem.Text = "0";
            this.continentBindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // continentBindingNavigatorSeparator1
            // 
            this.continentBindingNavigatorSeparator1.Name = "continentBindingNavigatorSeparator1";
            this.continentBindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // continentBindingNavigatorMoveNextItem
            // 
            this.continentBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorMoveNextItem.Image")));
            this.continentBindingNavigatorMoveNextItem.Name = "continentBindingNavigatorMoveNextItem";
            this.continentBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.continentBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // continentBindingNavigatorMoveLastItem
            // 
            this.continentBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorMoveLastItem.Image")));
            this.continentBindingNavigatorMoveLastItem.Name = "continentBindingNavigatorMoveLastItem";
            this.continentBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.continentBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // continentBindingNavigatorSeparator2
            // 
            this.continentBindingNavigatorSeparator2.Name = "continentBindingNavigatorSeparator2";
            this.continentBindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // continentBindingNavigatorSaveItem
            // 
            this.continentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("continentBindingNavigatorSaveItem.Image")));
            this.continentBindingNavigatorSaveItem.Name = "continentBindingNavigatorSaveItem";
            this.continentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.continentBindingNavigatorSaveItem.Text = "Save Data";
            this.continentBindingNavigatorSaveItem.Click += new System.EventHandler(this.continentBindingNavigatorSaveItem_Click);
            // 
            // tabPageCountry
            // 
            this.tabPageCountry.AutoScroll = true;
            this.tabPageCountry.Controls.Add(this.splitContainer);
            this.tabPageCountry.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountry.Name = "tabPageCountry";
            this.tabPageCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountry.Size = new System.Drawing.Size(792, 400);
            this.tabPageCountry.TabIndex = 1;
            this.tabPageCountry.Text = "Город";
            this.tabPageCountry.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.countryDataGridView);
            this.splitContainer.Panel1.Controls.Add(this.countryBindingNavigator);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(idLabel);
            this.splitContainer.Panel2.Controls.Add(this.idNumericUpDown);
            this.splitContainer.Panel2.Controls.Add(nameLabel);
            this.splitContainer.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer.Panel2.Controls.Add(continentLabel);
            this.splitContainer.Panel2.Controls.Add(this.id_continentComboBox);
            this.splitContainer.Panel2.Controls.Add(photoLabel);
            this.splitContainer.Panel2.Controls.Add(this.photoPictureBox);
            this.splitContainer.Size = new System.Drawing.Size(786, 394);
            this.splitContainer.SplitterDistance = 473;
            this.splitContainer.TabIndex = 0;
            // 
            // countryDataGridView
            // 
            this.countryDataGridView.AllowUserToAddRows = false;
            this.countryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryDataGridView.AutoGenerateColumns = false;
            this.countryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewComboBoxColumn5,
            this.dataGridViewImageColumn2});
            this.countryDataGridView.DataSource = this.countryBindingSource;
            this.countryDataGridView.Location = new System.Drawing.Point(8, 31);
            this.countryDataGridView.Name = "countryDataGridView";
            this.countryDataGridView.ReadOnly = true;
            this.countryDataGridView.Size = new System.Drawing.Size(441, 363);
            this.countryDataGridView.TabIndex = 0;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.countryDBDataSet;
            // 
            // countryBindingNavigator
            // 
            this.countryBindingNavigator.AddNewItem = this.countryBindingNavigatorAddNewItem;
            this.countryBindingNavigator.BindingSource = this.countryBindingSource;
            this.countryBindingNavigator.CountItem = this.countryBindingNavigatorCountItem;
            this.countryBindingNavigator.DeleteItem = this.countryBindingNavigatorDeleteItem;
            this.countryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryBindingNavigatorMoveFirstItem,
            this.countryBindingNavigatorMovePreviousItem,
            this.countryBindingNavigatorSeparator,
            this.countryBindingNavigatorPositionItem,
            this.countryBindingNavigatorCountItem,
            this.countryBindingNavigatorSeparator1,
            this.countryBindingNavigatorMoveNextItem,
            this.countryBindingNavigatorMoveLastItem,
            this.countryBindingNavigatorSeparator2,
            this.countryBindingNavigatorAddNewItem,
            this.countryBindingNavigatorDeleteItem,
            this.countryBindingNavigatorSaveItem});
            this.countryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countryBindingNavigator.MoveFirstItem = this.countryBindingNavigatorMoveFirstItem;
            this.countryBindingNavigator.MoveLastItem = this.countryBindingNavigatorMoveLastItem;
            this.countryBindingNavigator.MoveNextItem = this.countryBindingNavigatorMoveNextItem;
            this.countryBindingNavigator.MovePreviousItem = this.countryBindingNavigatorMovePreviousItem;
            this.countryBindingNavigator.Name = "countryBindingNavigator";
            this.countryBindingNavigator.PositionItem = this.countryBindingNavigatorPositionItem;
            this.countryBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.countryBindingNavigator.TabIndex = 10;
            this.countryBindingNavigator.Text = "bindingNavigator1";
            // 
            // countryBindingNavigatorAddNewItem
            // 
            this.countryBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorAddNewItem.Image")));
            this.countryBindingNavigatorAddNewItem.Name = "countryBindingNavigatorAddNewItem";
            this.countryBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.countryBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorAddNewItem.Text = "Add new";
            // 
            // countryBindingNavigatorCountItem
            // 
            this.countryBindingNavigatorCountItem.Name = "countryBindingNavigatorCountItem";
            this.countryBindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.countryBindingNavigatorCountItem.Text = "для {0}";
            this.countryBindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // countryBindingNavigatorDeleteItem
            // 
            this.countryBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorDeleteItem.Image")));
            this.countryBindingNavigatorDeleteItem.Name = "countryBindingNavigatorDeleteItem";
            this.countryBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.countryBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorDeleteItem.Text = "Delete";
            // 
            // countryBindingNavigatorMoveFirstItem
            // 
            this.countryBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorMoveFirstItem.Image")));
            this.countryBindingNavigatorMoveFirstItem.Name = "countryBindingNavigatorMoveFirstItem";
            this.countryBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.countryBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // countryBindingNavigatorMovePreviousItem
            // 
            this.countryBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorMovePreviousItem.Image")));
            this.countryBindingNavigatorMovePreviousItem.Name = "countryBindingNavigatorMovePreviousItem";
            this.countryBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.countryBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // countryBindingNavigatorSeparator
            // 
            this.countryBindingNavigatorSeparator.Name = "countryBindingNavigatorSeparator";
            this.countryBindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // countryBindingNavigatorPositionItem
            // 
            this.countryBindingNavigatorPositionItem.AccessibleName = "Position";
            this.countryBindingNavigatorPositionItem.AutoSize = false;
            this.countryBindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countryBindingNavigatorPositionItem.Name = "countryBindingNavigatorPositionItem";
            this.countryBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.countryBindingNavigatorPositionItem.Text = "0";
            this.countryBindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // countryBindingNavigatorSeparator1
            // 
            this.countryBindingNavigatorSeparator1.Name = "countryBindingNavigatorSeparator1";
            this.countryBindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // countryBindingNavigatorMoveNextItem
            // 
            this.countryBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorMoveNextItem.Image")));
            this.countryBindingNavigatorMoveNextItem.Name = "countryBindingNavigatorMoveNextItem";
            this.countryBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.countryBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // countryBindingNavigatorMoveLastItem
            // 
            this.countryBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorMoveLastItem.Image")));
            this.countryBindingNavigatorMoveLastItem.Name = "countryBindingNavigatorMoveLastItem";
            this.countryBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.countryBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // countryBindingNavigatorSeparator2
            // 
            this.countryBindingNavigatorSeparator2.Name = "countryBindingNavigatorSeparator2";
            this.countryBindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // countryBindingNavigatorSaveItem
            // 
            this.countryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorSaveItem.Image")));
            this.countryBindingNavigatorSaveItem.Name = "countryBindingNavigatorSaveItem";
            this.countryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorSaveItem.Text = "Save Data";
            this.countryBindingNavigatorSaveItem.Click += new System.EventHandler(this.countryBindingNavigatorSaveItem_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.countryBindingSource, "id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(89, 7);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(215, 20);
            this.idNumericUpDown.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(89, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // id_continentComboBox
            // 
            this.id_continentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "id_continent", true));
            this.id_continentComboBox.DataSource = this.continentBindingSource;
            this.id_continentComboBox.DisplayMember = "name";
            this.id_continentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_continentComboBox.FormattingEnabled = true;
            this.id_continentComboBox.Location = new System.Drawing.Point(89, 59);
            this.id_continentComboBox.Name = "id_continentComboBox";
            this.id_continentComboBox.Size = new System.Drawing.Size(215, 21);
            this.id_continentComboBox.TabIndex = 15;
            this.id_continentComboBox.ValueMember = "id";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.ContextMenuStrip = this.contextMenuStripPhoto;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.countryBindingSource, "photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(89, 93);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(215, 248);
            this.photoPictureBox.TabIndex = 17;
            this.photoPictureBox.TabStop = false;
            // 
            // contextMenuStripPhoto
            // 
            this.contextMenuStripPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.contextMenuStripPhoto.Name = "contextMenuStripPhoto";
            this.contextMenuStripPhoto.Size = new System.Drawing.Size(134, 70);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.uploadToolStripMenuItem.Text = "Загрузить";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.propertiesToolStripMenuItem.Text = "Свойства";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // continentTableAdapter
            // 
            this.continentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.continentTableAdapter = this.continentTableAdapter;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab12.CountryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Название";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.DataPropertyName = "id_continent";
            this.dataGridViewComboBoxColumn5.DataSource = this.continentBindingSource;
            this.dataGridViewComboBoxColumn5.DisplayMember = "name";
            this.dataGridViewComboBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn5.HeaderText = "Страна";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.ReadOnly = true;
            this.dataGridViewComboBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn5.ValueMember = "id";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "photo";
            this.dataGridViewImageColumn2.HeaderText = "Изображение";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageContinent.ResumeLayout(false);
            this.tabPageContinent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingNavigator)).EndInit();
            this.continentBindingNavigator.ResumeLayout(false);
            this.continentBindingNavigator.PerformLayout();
            this.tabPageCountry.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingNavigator)).EndInit();
            this.countryBindingNavigator.ResumeLayout(false);
            this.countryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.contextMenuStripPhoto.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageContinent;
        private System.Windows.Forms.TabPage tabPageCountry;
        private System.Windows.Forms.StatusStrip statusStrip;
        private CountryDBDataSet countryDBDataSet;
        private System.Windows.Forms.BindingSource continentBindingSource;
        private CountryDBDataSetTableAdapters.continentTableAdapter continentTableAdapter;
        private CountryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator continentBindingNavigator;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel continentBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator continentBindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox continentBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator continentBindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator continentBindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton continentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView continentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private CountryDBDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.DataGridView countryDataGridView;
        private System.Windows.Forms.BindingNavigator countryBindingNavigator;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel countryBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator countryBindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox countryBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator countryBindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator countryBindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox id_continentComboBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPhoto;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}

