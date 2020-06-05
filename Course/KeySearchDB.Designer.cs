namespace Course
{
    partial class KeySearchDB
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
            this.buttonKeySearch = new System.Windows.Forms.Button();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewDBKeySearch = new System.Windows.Forms.DataGridView();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBKeySearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя препарата для поиска";
            // 
            // buttonKeySearch
            // 
            this.buttonKeySearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonKeySearch.FlatAppearance.BorderSize = 0;
            this.buttonKeySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonKeySearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKeySearch.Location = new System.Drawing.Point(21, 84);
            this.buttonKeySearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeySearch.Name = "buttonKeySearch";
            this.buttonKeySearch.Size = new System.Drawing.Size(100, 43);
            this.buttonKeySearch.TabIndex = 2;
            this.buttonKeySearch.Text = "Поиск";
            this.buttonKeySearch.UseVisualStyleBackColor = false;
            this.buttonKeySearch.Click += new System.EventHandler(this.buttonKeySearch_Click);
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNameProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNameProduct.Location = new System.Drawing.Point(21, 46);
            this.textBoxNameProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(267, 30);
            this.textBoxNameProduct.TabIndex = 3;
            // 
            // dataGridViewDBKeySearch
            // 
            this.dataGridViewDBKeySearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBKeySearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePharm,
            this.Manufacturer,
            this.Price,
            this.Amount,
            this.PharmNumber,
            this.DateExpired});
            this.dataGridViewDBKeySearch.Location = new System.Drawing.Point(16, 260);
            this.dataGridViewDBKeySearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDBKeySearch.Name = "dataGridViewDBKeySearch";
            this.dataGridViewDBKeySearch.RowHeadersWidth = 51;
            this.dataGridViewDBKeySearch.Size = new System.Drawing.Size(1041, 303);
            this.dataGridViewDBKeySearch.TabIndex = 17;
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
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelError.ForeColor = System.Drawing.SystemColors.Window;
            this.labelError.Location = new System.Drawing.Point(21, 146);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(373, 28);
            this.labelError.TabIndex = 18;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KeySearchDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1073, 575);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.dataGridViewDBKeySearch);
            this.Controls.Add(this.textBoxNameProduct);
            this.Controls.Add(this.buttonKeySearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KeySearchDB";
            this.Text = "KeySearchDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBKeySearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeySearch;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.DataGridView dataGridViewDBKeySearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PharmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpired;
        private System.Windows.Forms.Label labelError;
    }
}