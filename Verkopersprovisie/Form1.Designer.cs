namespace Verkopersprovisie
{
    partial class Form1
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxEmplpoyees = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listBoxSold = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.numericUpDownMonth1 = new System.Windows.Forms.NumericUpDown();
            this.panelDay = new System.Windows.Forms.Panel();
            this.numericUpDownDay1 = new System.Windows.Forms.NumericUpDown();
            this.panelYear = new System.Windows.Forms.Panel();
            this.numericUpDownYear1 = new System.Windows.Forms.NumericUpDown();
            this.panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).BeginInit();
            this.panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).BeginInit();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.panelMonth);
            this.panelLayout.Controls.Add(this.panelDay);
            this.panelLayout.Controls.Add(this.panelYear);
            this.panelLayout.Controls.Add(this.listBoxProduct);
            this.panelLayout.Controls.Add(this.buttonRemoveProduct);
            this.panelLayout.Controls.Add(this.numericUpDownAmount);
            this.panelLayout.Controls.Add(this.buttonReset);
            this.panelLayout.Controls.Add(this.listBoxEmplpoyees);
            this.panelLayout.Controls.Add(this.buttonAddProduct);
            this.panelLayout.Controls.Add(this.listBoxSold);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(520, 426);
            this.panelLayout.TabIndex = 30;
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 16;
            this.listBoxProduct.Location = new System.Drawing.Point(3, 88);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(514, 68);
            this.listBoxProduct.TabIndex = 69;
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(108, 190);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(131, 33);
            this.buttonRemoveProduct.TabIndex = 68;
            this.buttonRemoveProduct.Text = "Remove Product";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.ButtonRemoveProduct_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(3, 162);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAmount.TabIndex = 64;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(442, 390);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 33);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listBoxEmplpoyees
            // 
            this.listBoxEmplpoyees.FormattingEnabled = true;
            this.listBoxEmplpoyees.ItemHeight = 16;
            this.listBoxEmplpoyees.Location = new System.Drawing.Point(3, 3);
            this.listBoxEmplpoyees.Name = "listBoxEmplpoyees";
            this.listBoxEmplpoyees.Size = new System.Drawing.Size(514, 68);
            this.listBoxEmplpoyees.TabIndex = 59;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(3, 190);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(99, 33);
            this.buttonAddProduct.TabIndex = 57;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // listBoxSold
            // 
            this.listBoxSold.FormattingEnabled = true;
            this.listBoxSold.ItemHeight = 16;
            this.listBoxSold.Location = new System.Drawing.Point(3, 229);
            this.listBoxSold.Name = "listBoxSold";
            this.listBoxSold.Size = new System.Drawing.Size(514, 68);
            this.listBoxSold.TabIndex = 57;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(3, 390);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(134, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "Show commission";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(3, 300);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(3, 365);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.numericUpDownMonth1);
            this.panelMonth.Location = new System.Drawing.Point(192, 162);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(47, 22);
            this.panelMonth.TabIndex = 71;
            // 
            // numericUpDownMonth1
            // 
            this.numericUpDownMonth1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth1.Name = "numericUpDownMonth1";
            this.numericUpDownMonth1.ReadOnly = true;
            this.numericUpDownMonth1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth1.TabIndex = 25;
            this.numericUpDownMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.numericUpDownDay1);
            this.panelDay.Location = new System.Drawing.Point(139, 162);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(47, 22);
            this.panelDay.TabIndex = 72;
            // 
            // numericUpDownDay1
            // 
            this.numericUpDownDay1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay1.Name = "numericUpDownDay1";
            this.numericUpDownDay1.ReadOnly = true;
            this.numericUpDownDay1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay1.TabIndex = 26;
            this.numericUpDownDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.numericUpDownYear1);
            this.panelYear.Location = new System.Drawing.Point(245, 161);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(67, 23);
            this.panelYear.TabIndex = 70;
            // 
            // numericUpDownYear1
            // 
            this.numericUpDownYear1.Location = new System.Drawing.Point(3, 1);
            this.numericUpDownYear1.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear1.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear1.Name = "numericUpDownYear1";
            this.numericUpDownYear1.ReadOnly = true;
            this.numericUpDownYear1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear1.TabIndex = 24;
            this.numericUpDownYear1.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.panelMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).EndInit();
            this.panelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).EndInit();
            this.panelYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxEmplpoyees;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ListBox listBoxSold;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth1;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.NumericUpDown numericUpDownDay1;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownYear1;
    }
}

