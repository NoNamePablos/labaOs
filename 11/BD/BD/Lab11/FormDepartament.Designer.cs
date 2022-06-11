
namespace Lab11
{
    partial class FormDepartament
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveDep = new System.Windows.Forms.Button();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSaveDep
            // 
            this.buttonSaveDep.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveDep.Location = new System.Drawing.Point(34, 109);
            this.buttonSaveDep.Name = "buttonSaveDep";
            this.buttonSaveDep.Size = new System.Drawing.Size(174, 31);
            this.buttonSaveDep.TabIndex = 1;
            this.buttonSaveDep.Text = "Сохранить";
            this.buttonSaveDep.UseVisualStyleBackColor = true;
            this.buttonSaveDep.Click += new System.EventHandler(this.buttonSaveDep_Click);
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new System.Drawing.Point(80, 82);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBank.TabIndex = 2;
            this.comboBoxBank.SelectedIndexChanged += new System.EventHandler(this.comboBoxBank_SelectedIndexChanged);
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Location = new System.Drawing.Point(80, 16);
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Банк";
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Location = new System.Drawing.Point(80, 56);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddres.TabIndex = 6;
            this.textBoxAddres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 152);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDepName);
            this.Controls.Add(this.comboBoxBank);
            this.Controls.Add(this.buttonSaveDep);
            this.Controls.Add(this.label1);
            this.Name = "FormDepartament";
            this.Text = "FormDepartament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveDep;
        private System.Windows.Forms.ComboBox comboBoxBank;
        private System.Windows.Forms.TextBox textBoxDepName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.Label label3;
    }
}