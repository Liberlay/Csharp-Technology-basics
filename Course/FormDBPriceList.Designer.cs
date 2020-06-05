namespace Course
{
    partial class FormDBPriceList
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
            this.dataGridViewDBPriceList = new System.Windows.Forms.DataGridView();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDBPriceList = new System.Windows.Forms.Label();
            this.buttonDBPriceList = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDBPriceList
            // 
            this.dataGridViewDBPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBPriceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePharm,
            this.Price,
            this.Amount,
            this.SumPrice});
            this.dataGridViewDBPriceList.Location = new System.Drawing.Point(16, 230);
            this.dataGridViewDBPriceList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDBPriceList.Name = "dataGridViewDBPriceList";
            this.dataGridViewDBPriceList.RowHeadersWidth = 51;
            this.dataGridViewDBPriceList.Size = new System.Drawing.Size(1035, 303);
            this.dataGridViewDBPriceList.TabIndex = 21;
            // 
            // NamePharm
            // 
            this.NamePharm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamePharm.HeaderText = "Название препарата";
            this.NamePharm.MinimumWidth = 6;
            this.NamePharm.Name = "NamePharm";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Количество";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SumPrice.HeaderText = "Общая стоимость";
            this.SumPrice.MinimumWidth = 6;
            this.SumPrice.Name = "SumPrice";
            // 
            // labelDBPriceList
            // 
            this.labelDBPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDBPriceList.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDBPriceList.Location = new System.Drawing.Point(260, 167);
            this.labelDBPriceList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDBPriceList.Name = "labelDBPriceList";
            this.labelDBPriceList.Size = new System.Drawing.Size(547, 25);
            this.labelDBPriceList.TabIndex = 20;
            this.labelDBPriceList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDBPriceList
            // 
            this.buttonDBPriceList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDBPriceList.FlatAppearance.BorderSize = 0;
            this.buttonDBPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBPriceList.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDBPriceList.Location = new System.Drawing.Point(363, 111);
            this.buttonDBPriceList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDBPriceList.Name = "buttonDBPriceList";
            this.buttonDBPriceList.Size = new System.Drawing.Size(321, 39);
            this.buttonDBPriceList.TabIndex = 19;
            this.buttonDBPriceList.Text = "Сформировать прайс-лист";
            this.buttonDBPriceList.UseVisualStyleBackColor = false;
            this.buttonDBPriceList.Click += new System.EventHandler(this.buttonDBPriceList_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Location = new System.Drawing.Point(363, 65);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(321, 30);
            this.textBoxFilePath.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(260, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите путь к базе данных, например (D:\\pharmacy)";
            // 
            // FormDBPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewDBPriceList);
            this.Controls.Add(this.labelDBPriceList);
            this.Controls.Add(this.buttonDBPriceList);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDBPriceList";
            this.Text = "FormDBPriceList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBPriceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDBPriceList;
        private System.Windows.Forms.Label labelDBPriceList;
        private System.Windows.Forms.Button buttonDBPriceList;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
    }
}