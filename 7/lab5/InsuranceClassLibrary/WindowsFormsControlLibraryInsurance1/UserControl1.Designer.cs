namespace WindowsFormsControlLibraryInsurance1
{
    partial class UserControlInsurance
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxTariffRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoDepartament = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInsuranceAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInsuranceType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(56, 15);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(56, 44);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxTariffRate
            // 
            this.textBoxTariffRate.Location = new System.Drawing.Point(183, 79);
            this.textBoxTariffRate.Name = "textBoxTariffRate";
            this.textBoxTariffRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxTariffRate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тарифная ставка";
            // 
            // textBoDepartament
            // 
            this.textBoDepartament.Location = new System.Drawing.Point(308, 34);
            this.textBoDepartament.Name = "textBoDepartament";
            this.textBoDepartament.Size = new System.Drawing.Size(100, 20);
            this.textBoDepartament.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Филиал";
            // 
            // textBoxInsuranceAmount
            // 
            this.textBoxInsuranceAmount.Location = new System.Drawing.Point(176, 34);
            this.textBoxInsuranceAmount.Name = "textBoxInsuranceAmount";
            this.textBoxInsuranceAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsuranceAmount.TabIndex = 12;
            this.textBoxInsuranceAmount.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Страховая сумма";
            // 
            // textBoxInsuranceType
            // 
            this.textBoxInsuranceType.Location = new System.Drawing.Point(308, 79);
            this.textBoxInsuranceType.Name = "textBoxInsuranceType";
            this.textBoxInsuranceType.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsuranceType.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Тип страхования";
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(429, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(21, 23);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxInsuranceType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInsuranceAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoDepartament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTariffRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Name = "UserControlInsurance";
            this.Size = new System.Drawing.Size(457, 103);
            this.Load += new System.EventHandler(this.UserControlInsurance_load);
            this.Click += new System.EventHandler(this.userControl1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBoxTariffRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoDepartament;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInsuranceAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInsuranceType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClose;
    }
}
