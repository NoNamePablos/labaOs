﻿
namespace Lab11
{
    partial class FormDateClient
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
            this.dateTimePickerLastDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFirstDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата Ухода";
            // 
            // dateTimePickerLastDate
            // 
            this.dateTimePickerLastDate.Location = new System.Drawing.Point(39, 204);
            this.dateTimePickerLastDate.Name = "dateTimePickerLastDate";
            this.dateTimePickerLastDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLastDate.TabIndex = 1;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(39, 54);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(200, 21);
            this.comboBoxClient.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(45, 244);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Клиент";
            // 
            // dateTimePickerFirstDate
            // 
            this.dateTimePickerFirstDate.Location = new System.Drawing.Point(39, 129);
            this.dateTimePickerFirstDate.Name = "dateTimePickerFirstDate";
            this.dateTimePickerFirstDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFirstDate.TabIndex = 6;
            this.dateTimePickerFirstDate.ValueChanged += new System.EventHandler(this.dateTimePickerFirstDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата Прихода";
            // 
            // FormDateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 288);
            this.Controls.Add(this.dateTimePickerFirstDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.dateTimePickerLastDate);
            this.Controls.Add(this.label1);
            this.Name = "FormDateClient";
            this.Text = "FormDateClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastDate;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDate;
        private System.Windows.Forms.Label label3;
    }
}