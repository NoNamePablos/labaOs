namespace Client
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
            this.comboBoxRequestType = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelJson = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelMaxDepth = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.numericUpDownArea = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRequestType
            // 
            this.comboBoxRequestType.DisplayMember = "Add";
            this.comboBoxRequestType.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequestType.FormattingEnabled = true;
            this.comboBoxRequestType.Items.AddRange(new object[] {
            "Добавить",
            "Получить",
            "Удалить",
            "Обновить"});
            this.comboBoxRequestType.Location = new System.Drawing.Point(0, 0);
            this.comboBoxRequestType.Name = "comboBoxRequestType";
            this.comboBoxRequestType.Size = new System.Drawing.Size(484, 21);
            this.comboBoxRequestType.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelJson});
            this.statusStrip.Location = new System.Drawing.Point(0, 137);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelJson
            // 
            this.toolStripStatusLabelJson.Name = "toolStripStatusLabelJson";
            this.toolStripStatusLabelJson.Size = new System.Drawing.Size(0, 17);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Название";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(12, 56);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(40, 13);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "Длина";
            // 
            // labelMaxDepth
            // 
            this.labelMaxDepth.AutoSize = true;
            this.labelMaxDepth.Location = new System.Drawing.Point(12, 82);
            this.labelMaxDepth.Name = "labelMaxDepth";
            this.labelMaxDepth.Size = new System.Drawing.Size(127, 13);
            this.labelMaxDepth.TabIndex = 4;
            this.labelMaxDepth.Text = "Максимальная глубина";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(145, 27);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(327, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(397, 105);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // numericUpDownArea
            // 
            this.numericUpDownArea.Location = new System.Drawing.Point(145, 54);
            this.numericUpDownArea.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownArea.Name = "numericUpDownArea";
            this.numericUpDownArea.Size = new System.Drawing.Size(327, 20);
            this.numericUpDownArea.TabIndex = 9;
            // 
            // numericUpDownMaxDepth
            // 
            this.numericUpDownMaxDepth.Location = new System.Drawing.Point(145, 80);
            this.numericUpDownMaxDepth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMaxDepth.Name = "numericUpDownMaxDepth";
            this.numericUpDownMaxDepth.Size = new System.Drawing.Size(327, 20);
            this.numericUpDownMaxDepth.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 159);
            this.Controls.Add(this.numericUpDownMaxDepth);
            this.Controls.Add(this.numericUpDownArea);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelMaxDepth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.comboBoxRequestType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Клиент";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRequestType;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelMaxDepth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelJson;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.NumericUpDown numericUpDownArea;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxDepth;
    }
}

