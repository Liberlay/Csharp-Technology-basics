namespace Course
{
    partial class FormProductsInPharmacy
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
            this.buttonOutputDBProductsInPharmacy = new System.Windows.Forms.Button();
            this.textBoxPharmNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDBProductsInPharmacy = new System.Windows.Forms.DataGridView();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBProductsInPharmacy)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOutputDBProductsInPharmacy
            // 
            this.buttonOutputDBProductsInPharmacy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOutputDBProductsInPharmacy.FlatAppearance.BorderSize = 0;
            this.buttonOutputDBProductsInPharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutputDBProductsInPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOutputDBProductsInPharmacy.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOutputDBProductsInPharmacy.Location = new System.Drawing.Point(261, 85);
            this.buttonOutputDBProductsInPharmacy.Name = "buttonOutputDBProductsInPharmacy";
            this.buttonOutputDBProductsInPharmacy.Size = new System.Drawing.Size(271, 54);
            this.buttonOutputDBProductsInPharmacy.TabIndex = 3;
            this.buttonOutputDBProductsInPharmacy.Text = "Сформировать вывод";
            this.buttonOutputDBProductsInPharmacy.UseVisualStyleBackColor = false;
            this.buttonOutputDBProductsInPharmacy.Click += new System.EventHandler(this.buttonOutputDBProductsInPharmacy_Click);
            // 
            // textBoxPharmNumber
            // 
            this.textBoxPharmNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPharmNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPharmNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPharmNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPharmNumber.Location = new System.Drawing.Point(261, 49);
            this.textBoxPharmNumber.Name = "textBoxPharmNumber";
            this.textBoxPharmNumber.Size = new System.Drawing.Size(271, 26);
            this.textBoxPharmNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(302, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите номер аптеки";
            // 
            // dataGridViewDBProductsInPharmacy
            // 
            this.dataGridViewDBProductsInPharmacy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBProductsInPharmacy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePharm,
            this.Manufacturer,
            this.Price,
            this.Amount,
            this.PharmNumber,
            this.DateExpired});
            this.dataGridViewDBProductsInPharmacy.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewDBProductsInPharmacy.Name = "dataGridViewDBProductsInPharmacy";
            this.dataGridViewDBProductsInPharmacy.Size = new System.Drawing.Size(784, 246);
            this.dataGridViewDBProductsInPharmacy.TabIndex = 18;
            // 
            // NamePharm
            // 
            this.NamePharm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamePharm.HeaderText = "Название препарата";
            this.NamePharm.Name = "NamePharm";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manufacturer.HeaderText = "Изготовитель";
            this.Manufacturer.Name = "Manufacturer";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.Width = 58;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.Width = 91;
            // 
            // PharmNumber
            // 
            this.PharmNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PharmNumber.HeaderText = "Номер аптеки";
            this.PharmNumber.Name = "PharmNumber";
            // 
            // DateExpired
            // 
            this.DateExpired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateExpired.HeaderText = "Срок годности";
            this.DateExpired.Name = "DateExpired";
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelError.ForeColor = System.Drawing.SystemColors.Window;
            this.labelError.Location = new System.Drawing.Point(261, 151);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(271, 23);
            this.labelError.TabIndex = 4;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormProductsInPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(808, 446);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.dataGridViewDBProductsInPharmacy);
            this.Controls.Add(this.buttonOutputDBProductsInPharmacy);
            this.Controls.Add(this.textBoxPharmNumber);
            this.Controls.Add(this.label2);
            this.Name = "FormProductsInPharmacy";
            this.Text = "FormProductsInPharmacy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBProductsInPharmacy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPharmNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOutputDBProductsInPharmacy;
        private System.Windows.Forms.DataGridView dataGridViewDBProductsInPharmacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PharmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpired;
        private System.Windows.Forms.Label labelError;
    }
}