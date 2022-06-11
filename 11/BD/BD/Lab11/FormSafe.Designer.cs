
namespace Lab11
{
    partial class FormSafe
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
            this.comboBoxSafe = new System.Windows.Forms.ComboBox();
            this.labelPos = new System.Windows.Forms.Label();
            this.buttonSafe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSafe
            // 
            this.comboBoxSafe.FormattingEnabled = true;
            this.comboBoxSafe.Location = new System.Drawing.Point(12, 67);
            this.comboBoxSafe.Name = "comboBoxSafe";
            this.comboBoxSafe.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSafe.TabIndex = 0;
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(53, 36);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(88, 13);
            this.labelPos.TabIndex = 1;
            this.labelPos.Text = "Позиция ключа:";
            // 
            // buttonSafe
            // 
            this.buttonSafe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSafe.Location = new System.Drawing.Point(30, 182);
            this.buttonSafe.Name = "buttonSafe";
            this.buttonSafe.Size = new System.Drawing.Size(127, 42);
            this.buttonSafe.TabIndex = 2;
            this.buttonSafe.Text = "Сохранить";
            this.buttonSafe.UseVisualStyleBackColor = true;
            this.buttonSafe.Click += new System.EventHandler(this.buttonSafe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Клиент";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 147);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(173, 21);
            this.comboBoxClient.TabIndex = 3;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // FormSafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonSafe);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.comboBoxSafe);
            this.Name = "FormSafe";
            this.Text = "FormSafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSafe;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Button buttonSafe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}