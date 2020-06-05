namespace Course
{
    partial class FormOutputDB
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
            this.dataGridViewDBOutput = new System.Windows.Forms.DataGridView();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelOutputDB = new System.Windows.Forms.Label();
            this.buttonDBOutput = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formOutputDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formOutputDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDBOutput
            // 
            this.dataGridViewDBOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePharm,
            this.Manufacturer,
            this.Price,
            this.Amount,
            this.PharmNumber,
            this.DateExpired});
            this.dataGridViewDBOutput.Location = new System.Drawing.Point(16, 194);
            this.dataGridViewDBOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDBOutput.Name = "dataGridViewDBOutput";
            this.dataGridViewDBOutput.RowHeadersWidth = 51;
            this.dataGridViewDBOutput.Size = new System.Drawing.Size(1035, 303);
            this.dataGridViewDBOutput.TabIndex = 0;
            // 
            // NamePharm
            // 
            this.NamePharm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamePharm.HeaderText = "Название препарата";
            this.NamePharm.MinimumWidth = 6;
            this.NamePharm.Name = "NamePharm";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manufacturer.HeaderText = "Изготовитель";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 72;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Amount.HeaderText = "Количество";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 115;
            // 
            // PharmNumber
            // 
            this.PharmNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PharmNumber.HeaderText = "Номер аптеки";
            this.PharmNumber.MinimumWidth = 6;
            this.PharmNumber.Name = "PharmNumber";
            // 
            // DateExpired
            // 
            this.DateExpired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateExpired.HeaderText = "Срок годности";
            this.DateExpired.MinimumWidth = 6;
            this.DateExpired.Name = "DateExpired";
            // 
            // labelOutputDB
            // 
            this.labelOutputDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOutputDB.ForeColor = System.Drawing.SystemColors.Window;
            this.labelOutputDB.Location = new System.Drawing.Point(280, 166);
            this.labelOutputDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutputDB.Name = "labelOutputDB";
            this.labelOutputDB.Size = new System.Drawing.Size(485, 25);
            this.labelOutputDB.TabIndex = 11;
            this.labelOutputDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDBOutput
            // 
            this.buttonDBOutput.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDBOutput.FlatAppearance.BorderSize = 0;
            this.buttonDBOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDBOutput.Location = new System.Drawing.Point(364, 100);
            this.buttonDBOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDBOutput.Name = "buttonDBOutput";
            this.buttonDBOutput.Size = new System.Drawing.Size(321, 39);
            this.buttonDBOutput.TabIndex = 10;
            this.buttonDBOutput.Text = "Сформировать вывод";
            this.buttonDBOutput.UseVisualStyleBackColor = false;
            this.buttonDBOutput.Click += new System.EventHandler(this.buttonDBOutput_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Location = new System.Drawing.Point(364, 54);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(321, 30);
            this.textBoxFilePath.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(261, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите путь к базе данных, например (D:\\pharmacy)";
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataSource = typeof(Course.Pharmacy);
            // 
            // pharmacyBindingSource1
            // 
            this.pharmacyBindingSource1.DataSource = typeof(Course.Pharmacy);
            // 
            // formOutputDBBindingSource
            // 
            this.formOutputDBBindingSource.DataSource = typeof(Course.FormOutputDB);
            // 
            // FormOutputDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelOutputDB);
            this.Controls.Add(this.buttonDBOutput);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDBOutput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOutputDB";
            this.Text = "FormOutputDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formOutputDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDBOutput;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private System.Windows.Forms.Label labelOutputDB;
        private System.Windows.Forms.Button buttonDBOutput;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pharmacyBindingSource1;
        private System.Windows.Forms.BindingSource formOutputDBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PharmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpired;
    }
}