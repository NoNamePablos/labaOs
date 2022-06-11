
namespace Lab11
{
    partial class FormCountry
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
            this.labelCountryName = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCountryPopulation = new System.Windows.Forms.TextBox();
            this.labelCountryPopulation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(12, 15);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(29, 13);
            this.labelCountryName.TabIndex = 0;
            this.labelCountryName.Text = "Имя";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(69, 12);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(59, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCountryPopulation
            // 
            this.textBoxCountryPopulation.Location = new System.Drawing.Point(69, 38);
            this.textBoxCountryPopulation.Name = "textBoxCountryPopulation";
            this.textBoxCountryPopulation.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryPopulation.TabIndex = 4;
            // 
            // labelCountryPopulation
            // 
            this.labelCountryPopulation.AutoSize = true;
            this.labelCountryPopulation.Location = new System.Drawing.Point(12, 41);
            this.labelCountryPopulation.Name = "labelCountryPopulation";
            this.labelCountryPopulation.Size = new System.Drawing.Size(29, 13);
            this.labelCountryPopulation.TabIndex = 3;
            this.labelCountryPopulation.Text = "Имя";
            // 
            // FormCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 187);
            this.Controls.Add(this.textBoxCountryPopulation);
            this.Controls.Add(this.labelCountryPopulation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.labelCountryName);
            this.Name = "FormCountry";
            this.Text = "FormCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCountryPopulation;
        private System.Windows.Forms.Label labelCountryPopulation;
    }
}