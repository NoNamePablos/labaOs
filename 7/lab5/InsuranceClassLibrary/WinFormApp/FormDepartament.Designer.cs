
namespace WinFormApp
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
            this.textBoxDepartament = new System.Windows.Forms.TextBox();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoTelephone = new System.Windows.Forms.TextBox();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDepartament
            // 
            this.textBoxDepartament.Location = new System.Drawing.Point(91, 35);
            this.textBoxDepartament.Name = "textBoxDepartament";
            this.textBoxDepartament.Size = new System.Drawing.Size(100, 23);
            this.textBoxDepartament.TabIndex = 0;
            this.textBoxDepartament.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Location = new System.Drawing.Point(91, 77);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(100, 23);
            this.textBoxAddres.TabIndex = 1;
            this.textBoxAddres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Филиал";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // textBoTelephone
            // 
            this.textBoTelephone.Location = new System.Drawing.Point(91, 120);
            this.textBoTelephone.Name = "textBoTelephone";
            this.textBoTelephone.Size = new System.Drawing.Size(100, 23);
            this.textBoTelephone.TabIndex = 5;
            // 
            // buttonComplete
            // 
            this.buttonComplete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonComplete.Location = new System.Drawing.Point(35, 149);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(156, 42);
            this.buttonComplete.TabIndex = 6;
            this.buttonComplete.Text = "Сохранить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // FormDepartament
            // 
            this.AcceptButton = this.buttonComplete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 203);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.textBoTelephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.textBoxDepartament);
            this.Name = "FormDepartament";
            this.Text = "Филиал";
            this.Load += new System.EventHandler(this.FormDepartament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDepartament;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoTelephone;
        private System.Windows.Forms.Button buttonComplete;
    }
}