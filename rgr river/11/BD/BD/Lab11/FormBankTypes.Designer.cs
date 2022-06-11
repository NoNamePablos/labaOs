
namespace Lab11
{
    partial class FormBankTypes
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
            this.labelBankName = new System.Windows.Forms.Label();
            this.textBoxNameBank = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonBankSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBankName
            // 
            this.labelBankName.AutoSize = true;
            this.labelBankName.Location = new System.Drawing.Point(56, 21);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(94, 13);
            this.labelBankName.TabIndex = 0;
            this.labelBankName.Text = "Название Банка:";
            this.labelBankName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNameBank
            // 
            this.textBoxNameBank.Location = new System.Drawing.Point(50, 50);
            this.textBoxNameBank.Name = "textBoxNameBank";
            this.textBoxNameBank.Size = new System.Drawing.Size(113, 20);
            this.textBoxNameBank.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonBankSave
            // 
            this.buttonBankSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonBankSave.Location = new System.Drawing.Point(59, 93);
            this.buttonBankSave.Name = "buttonBankSave";
            this.buttonBankSave.Size = new System.Drawing.Size(91, 34);
            this.buttonBankSave.TabIndex = 3;
            this.buttonBankSave.Text = "Сохранить";
            this.buttonBankSave.UseVisualStyleBackColor = true;
            this.buttonBankSave.Click += new System.EventHandler(this.buttonBankSave_Click);
            // 
            // FormBankTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 157);
            this.Controls.Add(this.buttonBankSave);
            this.Controls.Add(this.textBoxNameBank);
            this.Controls.Add(this.labelBankName);
            this.Name = "FormBankTypes";
            this.Text = "FormBankTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBankName;
        private System.Windows.Forms.TextBox textBoxNameBank;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonBankSave;
    }
}