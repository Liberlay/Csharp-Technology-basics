namespace Course
{
    partial class FormMoreThen100
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
            this.buttonDBMoreThen100 = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDBMoreThen100 = new System.Windows.Forms.Label();
            this.dataGridViewDBMoreThen100 = new System.Windows.Forms.DataGridView();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBMoreThen100)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDBMoreThen100
            // 
            this.buttonDBMoreThen100.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDBMoreThen100.FlatAppearance.BorderSize = 0;
            this.buttonDBMoreThen100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBMoreThen100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBMoreThen100.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDBMoreThen100.Location = new System.Drawing.Point(363, 117);
            this.buttonDBMoreThen100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDBMoreThen100.Name = "buttonDBMoreThen100";
            this.buttonDBMoreThen100.Size = new System.Drawing.Size(321, 39);
            this.buttonDBMoreThen100.TabIndex = 13;
            this.buttonDBMoreThen100.Text = "Сформировать вывод";
            this.buttonDBMoreThen100.UseVisualStyleBackColor = false;
            this.buttonDBMoreThen100.Click += new System.EventHandler(this.buttonDBMoreThen100_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Location = new System.Drawing.Point(363, 71);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(321, 30);
            this.textBoxFilePath.TabIndex = 12;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.textBoxFilePath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите путь к базе данных, например (D:\\pharmacy)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDBMoreThen100
            // 
            this.labelDBMoreThen100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDBMoreThen100.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDBMoreThen100.Location = new System.Drawing.Point(260, 174);
            this.labelDBMoreThen100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDBMoreThen100.Name = "labelDBMoreThen100";
            this.labelDBMoreThen100.Size = new System.Drawing.Size(547, 25);
            this.labelDBMoreThen100.TabIndex = 15;
            this.labelDBMoreThen100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDBMoreThen100.Click += new System.EventHandler(this.labelDBMoreThen100_Click);
            // 
            // dataGridViewDBMoreThen100
            // 
            this.dataGridViewDBMoreThen100.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBMoreThen100.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePharm,
            this.Manufacturer,
            this.Price,
            this.Amount,
            this.PharmNumber,
            this.DateExpired});
            this.dataGridViewDBMoreThen100.Location = new System.Drawing.Point(16, 236);
            this.dataGridViewDBMoreThen100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDBMoreThen100.Name = "dataGridViewDBMoreThen100";
            this.dataGridViewDBMoreThen100.RowHeadersWidth = 51;
            this.dataGridViewDBMoreThen100.Size = new System.Drawing.Size(1035, 303);
            this.dataGridViewDBMoreThen100.TabIndex = 16;
            this.dataGridViewDBMoreThen100.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDBMoreThen100_CellContentClick);
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
            // FormMoreThen100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewDBMoreThen100);
            this.Controls.Add(this.labelDBMoreThen100);
            this.Controls.Add(this.buttonDBMoreThen100);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMoreThen100";
            this.Text = "FormMoreThen100";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBMoreThen100)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDBMoreThen100;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDBMoreThen100;
        private System.Windows.Forms.DataGridView dataGridViewDBMoreThen100;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PharmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpired;
    }
}