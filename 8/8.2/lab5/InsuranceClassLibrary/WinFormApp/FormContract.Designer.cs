
namespace WinFormApp
{
    partial class FormContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContract));
            this.labelNameContract = new System.Windows.Forms.Label();
            this.textBoxNumberContract = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelInsuranceAmount = new System.Windows.Forms.Label();
            this.labelTariffRate = new System.Windows.Forms.Label();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.comboBoxDepartament = new System.Windows.Forms.ComboBox();
            this.labelTypeIns = new System.Windows.Forms.Label();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.numericUpDownInsuranceAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTariffRate = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTypeInsurance = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInsuranceAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTariffRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameContract
            // 
            resources.ApplyResources(this.labelNameContract, "labelNameContract");
            this.labelNameContract.Name = "labelNameContract";
            // 
            // textBoxNumberContract
            // 
            resources.ApplyResources(this.textBoxNumberContract, "textBoxNumberContract");
            this.textBoxNumberContract.Name = "textBoxNumberContract";
            this.textBoxNumberContract.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDate
            // 
            resources.ApplyResources(this.labelDate, "labelDate");
            this.labelDate.Name = "labelDate";
            // 
            // dateTimePickerDate
            // 
            resources.ApplyResources(this.dateTimePickerDate, "dateTimePickerDate");
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            // 
            // labelInsuranceAmount
            // 
            resources.ApplyResources(this.labelInsuranceAmount, "labelInsuranceAmount");
            this.labelInsuranceAmount.Name = "labelInsuranceAmount";
            // 
            // labelTariffRate
            // 
            resources.ApplyResources(this.labelTariffRate, "labelTariffRate");
            this.labelTariffRate.Name = "labelTariffRate";
            // 
            // labelDepartament
            // 
            resources.ApplyResources(this.labelDepartament, "labelDepartament");
            this.labelDepartament.Name = "labelDepartament";
            // 
            // comboBoxDepartament
            // 
            this.comboBoxDepartament.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxDepartament, "comboBoxDepartament");
            this.comboBoxDepartament.Name = "comboBoxDepartament";
            this.comboBoxDepartament.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTypeIns
            // 
            resources.ApplyResources(this.labelTypeIns, "labelTypeIns");
            this.labelTypeIns.Name = "labelTypeIns";
            // 
            // buttonComplete
            // 
            this.buttonComplete.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonComplete, "buttonComplete");
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // numericUpDownInsuranceAmount
            // 
            resources.ApplyResources(this.numericUpDownInsuranceAmount, "numericUpDownInsuranceAmount");
            this.numericUpDownInsuranceAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownInsuranceAmount.Name = "numericUpDownInsuranceAmount";
            this.numericUpDownInsuranceAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownTariffRate
            // 
            resources.ApplyResources(this.numericUpDownTariffRate, "numericUpDownTariffRate");
            this.numericUpDownTariffRate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownTariffRate.Name = "numericUpDownTariffRate";
            this.numericUpDownTariffRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBoxTypeInsurance
            // 
            this.comboBoxTypeInsurance.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxTypeInsurance, "comboBoxTypeInsurance");
            this.comboBoxTypeInsurance.Name = "comboBoxTypeInsurance";
            this.comboBoxTypeInsurance.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // FormContract
            // 
            this.AcceptButton = this.buttonComplete;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxTypeInsurance);
            this.Controls.Add(this.numericUpDownTariffRate);
            this.Controls.Add(this.numericUpDownInsuranceAmount);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.labelTypeIns);
            this.Controls.Add(this.comboBoxDepartament);
            this.Controls.Add(this.labelDepartament);
            this.Controls.Add(this.labelTariffRate);
            this.Controls.Add(this.labelInsuranceAmount);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxNumberContract);
            this.Controls.Add(this.labelNameContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormContract";
            this.Load += new System.EventHandler(this.FormContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInsuranceAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTariffRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameContract;
        private System.Windows.Forms.TextBox textBoxNumberContract;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelInsuranceAmount;
        private System.Windows.Forms.Label labelTariffRate;
        private System.Windows.Forms.Label labelDepartament;
        private System.Windows.Forms.ComboBox comboBoxDepartament;
        private System.Windows.Forms.Label labelTypeIns;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.NumericUpDown numericUpDownInsuranceAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownTariffRate;
        private System.Windows.Forms.ComboBox comboBoxTypeInsurance;
    }
}