
namespace Lab11
{
    partial class FormDateTrustedPerson
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxTrusted = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFirstdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLastDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(12, 212);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(223, 37);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxTrusted
            // 
            this.comboBoxTrusted.FormattingEnabled = true;
            this.comboBoxTrusted.Location = new System.Drawing.Point(12, 44);
            this.comboBoxTrusted.Name = "comboBoxTrusted";
            this.comboBoxTrusted.Size = new System.Drawing.Size(223, 21);
            this.comboBoxTrusted.TabIndex = 1;
            // 
            // dateTimePickerFirstdate
            // 
            this.dateTimePickerFirstdate.Location = new System.Drawing.Point(12, 115);
            this.dateTimePickerFirstdate.Name = "dateTimePickerFirstdate";
            this.dateTimePickerFirstdate.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerFirstdate.TabIndex = 2;
            // 
            // dateTimePickerLastDate
            // 
            this.dateTimePickerLastDate.Location = new System.Drawing.Point(12, 186);
            this.dateTimePickerLastDate.Name = "dateTimePickerLastDate";
            this.dateTimePickerLastDate.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerLastDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Доверенное лицо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата Прихода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата Ухода";
            // 
            // FormDateTrustedPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerLastDate);
            this.Controls.Add(this.dateTimePickerFirstdate);
            this.Controls.Add(this.comboBoxTrusted);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormDateTrustedPerson";
            this.Text = "FormDateTrustedPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxTrusted;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}