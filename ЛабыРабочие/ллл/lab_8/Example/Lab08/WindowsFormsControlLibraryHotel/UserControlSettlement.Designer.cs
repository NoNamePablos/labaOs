namespace WindowsFormsControlLibraryHotel
{
    partial class UserControlSettlement
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
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(3, 7);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Клиент:";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(55, 4);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(263, 20);
            this.textBoxClient.TabIndex = 1;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(324, 7);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(44, 13);
            this.labelRoom.TabIndex = 2;
            this.labelRoom.Text = "Номер:";
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(374, 4);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.ReadOnly = true;
            this.textBoxRoom.Size = new System.Drawing.Size(86, 20);
            this.textBoxRoom.TabIndex = 3;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(3, 33);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(113, 13);
            this.labelPeriod.TabIndex = 4;
            this.labelPeriod.Text = "Период проживания:";
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(122, 30);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.ReadOnly = true;
            this.textBoxPeriod.Size = new System.Drawing.Size(305, 20);
            this.textBoxPeriod.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(433, 29);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(27, 21);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "x";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UserControlSettlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.labelClient);
            this.Name = "UserControlSettlement";
            this.Size = new System.Drawing.Size(474, 58);
            this.Click += new System.EventHandler(this.UserControlSettlement_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlSettlement_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Button buttonDelete;
    }
}
