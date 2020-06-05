namespace Course
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddDataBase = new System.Windows.Forms.Button();
            this.buttonReportOutputDB = new System.Windows.Forms.Button();
            this.buttonAddFieldDB = new System.Windows.Forms.Button();
            this.buttonEditDB = new System.Windows.Forms.Button();
            this.buttonDeleteDB = new System.Windows.Forms.Button();
            this.buttonSearchFieldDB = new System.Windows.Forms.Button();
            this.buttonReport100InPack = new System.Windows.Forms.Button();
            this.buttonDeleteExpired = new System.Windows.Forms.Button();
            this.buttonReportProductsInPharmacy = new System.Windows.Forms.Button();
            this.buttonReportPriceList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddDataBase
            // 
            this.buttonAddDataBase.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddDataBase.FlatAppearance.BorderSize = 0;
            this.buttonAddDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddDataBase.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddDataBase.Location = new System.Drawing.Point(68, 12);
            this.buttonAddDataBase.Name = "buttonAddDataBase";
            this.buttonAddDataBase.Size = new System.Drawing.Size(241, 39);
            this.buttonAddDataBase.TabIndex = 0;
            this.buttonAddDataBase.Text = "Создать базу данных";
            this.buttonAddDataBase.UseVisualStyleBackColor = false;
            this.buttonAddDataBase.Click += new System.EventHandler(this.buttonAddDataBase_Click);
            // 
            // buttonReportOutputDB
            // 
            this.buttonReportOutputDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonReportOutputDB.FlatAppearance.BorderSize = 0;
            this.buttonReportOutputDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportOutputDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReportOutputDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReportOutputDB.Location = new System.Drawing.Point(68, 57);
            this.buttonReportOutputDB.Name = "buttonReportOutputDB";
            this.buttonReportOutputDB.Size = new System.Drawing.Size(241, 37);
            this.buttonReportOutputDB.TabIndex = 1;
            this.buttonReportOutputDB.Text = "Вывод отчета";
            this.buttonReportOutputDB.UseVisualStyleBackColor = false;
            this.buttonReportOutputDB.Click += new System.EventHandler(this.buttonReportOutputDB_Click);
            // 
            // buttonAddFieldDB
            // 
            this.buttonAddFieldDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddFieldDB.FlatAppearance.BorderSize = 0;
            this.buttonAddFieldDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFieldDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddFieldDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddFieldDB.Location = new System.Drawing.Point(68, 100);
            this.buttonAddFieldDB.Name = "buttonAddFieldDB";
            this.buttonAddFieldDB.Size = new System.Drawing.Size(241, 43);
            this.buttonAddFieldDB.TabIndex = 2;
            this.buttonAddFieldDB.Text = "Добавить запись";
            this.buttonAddFieldDB.UseVisualStyleBackColor = false;
            this.buttonAddFieldDB.Click += new System.EventHandler(this.buttonAddFieldDB_Click);
            // 
            // buttonEditDB
            // 
            this.buttonEditDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditDB.FlatAppearance.BorderSize = 0;
            this.buttonEditDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEditDB.Location = new System.Drawing.Point(68, 149);
            this.buttonEditDB.Name = "buttonEditDB";
            this.buttonEditDB.Size = new System.Drawing.Size(241, 39);
            this.buttonEditDB.TabIndex = 3;
            this.buttonEditDB.Text = "Редактировать базу данных";
            this.buttonEditDB.UseVisualStyleBackColor = false;
            this.buttonEditDB.Click += new System.EventHandler(this.buttonEditDB_Click);
            // 
            // buttonDeleteDB
            // 
            this.buttonDeleteDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteDB.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteDB.Location = new System.Drawing.Point(68, 194);
            this.buttonDeleteDB.Name = "buttonDeleteDB";
            this.buttonDeleteDB.Size = new System.Drawing.Size(241, 35);
            this.buttonDeleteDB.TabIndex = 4;
            this.buttonDeleteDB.Text = "Удалить базу данных";
            this.buttonDeleteDB.UseVisualStyleBackColor = false;
            this.buttonDeleteDB.Click += new System.EventHandler(this.buttonDeleteDB_Click);
            // 
            // buttonSearchFieldDB
            // 
            this.buttonSearchFieldDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSearchFieldDB.FlatAppearance.BorderSize = 0;
            this.buttonSearchFieldDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchFieldDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearchFieldDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchFieldDB.Location = new System.Drawing.Point(68, 235);
            this.buttonSearchFieldDB.Name = "buttonSearchFieldDB";
            this.buttonSearchFieldDB.Size = new System.Drawing.Size(241, 37);
            this.buttonSearchFieldDB.TabIndex = 5;
            this.buttonSearchFieldDB.Text = "Поиск записей";
            this.buttonSearchFieldDB.UseVisualStyleBackColor = false;
            this.buttonSearchFieldDB.Click += new System.EventHandler(this.buttonSearchFieldDB_Click);
            // 
            // buttonReport100InPack
            // 
            this.buttonReport100InPack.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonReport100InPack.FlatAppearance.BorderSize = 0;
            this.buttonReport100InPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport100InPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReport100InPack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReport100InPack.Location = new System.Drawing.Point(68, 361);
            this.buttonReport100InPack.Name = "buttonReport100InPack";
            this.buttonReport100InPack.Size = new System.Drawing.Size(241, 50);
            this.buttonReport100InPack.TabIndex = 6;
            this.buttonReport100InPack.Text = "Товары >100ед. в уп-ке";
            this.buttonReport100InPack.UseVisualStyleBackColor = false;
            this.buttonReport100InPack.Click += new System.EventHandler(this.buttonReport100InPack_Click);
            // 
            // buttonDeleteExpired
            // 
            this.buttonDeleteExpired.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteExpired.FlatAppearance.BorderSize = 0;
            this.buttonDeleteExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteExpired.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteExpired.Location = new System.Drawing.Point(68, 278);
            this.buttonDeleteExpired.Name = "buttonDeleteExpired";
            this.buttonDeleteExpired.Size = new System.Drawing.Size(241, 77);
            this.buttonDeleteExpired.TabIndex = 7;
            this.buttonDeleteExpired.Text = "Удалить просроченные товары";
            this.buttonDeleteExpired.UseVisualStyleBackColor = false;
            this.buttonDeleteExpired.Click += new System.EventHandler(this.buttonDeleteExpired_Click);
            // 
            // buttonReportProductsInPharmacy
            // 
            this.buttonReportProductsInPharmacy.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonReportProductsInPharmacy.FlatAppearance.BorderSize = 0;
            this.buttonReportProductsInPharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportProductsInPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReportProductsInPharmacy.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReportProductsInPharmacy.Location = new System.Drawing.Point(68, 417);
            this.buttonReportProductsInPharmacy.Name = "buttonReportProductsInPharmacy";
            this.buttonReportProductsInPharmacy.Size = new System.Drawing.Size(241, 37);
            this.buttonReportProductsInPharmacy.TabIndex = 8;
            this.buttonReportProductsInPharmacy.Text = "Товары в аптеке";
            this.buttonReportProductsInPharmacy.UseVisualStyleBackColor = false;
            this.buttonReportProductsInPharmacy.Click += new System.EventHandler(this.buttonReportProductsInPharmacy_Click);
            // 
            // buttonReportPriceList
            // 
            this.buttonReportPriceList.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonReportPriceList.FlatAppearance.BorderSize = 0;
            this.buttonReportPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReportPriceList.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReportPriceList.Location = new System.Drawing.Point(68, 460);
            this.buttonReportPriceList.Name = "buttonReportPriceList";
            this.buttonReportPriceList.Size = new System.Drawing.Size(241, 32);
            this.buttonReportPriceList.TabIndex = 9;
            this.buttonReportPriceList.Text = "Общий прайс-лист";
            this.buttonReportPriceList.UseVisualStyleBackColor = false;
            this.buttonReportPriceList.Click += new System.EventHandler(this.buttonReportPriceList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(374, 506);
            this.Controls.Add(this.buttonReportPriceList);
            this.Controls.Add(this.buttonReportProductsInPharmacy);
            this.Controls.Add(this.buttonDeleteExpired);
            this.Controls.Add(this.buttonReport100InPack);
            this.Controls.Add(this.buttonSearchFieldDB);
            this.Controls.Add(this.buttonDeleteDB);
            this.Controls.Add(this.buttonEditDB);
            this.Controls.Add(this.buttonAddFieldDB);
            this.Controls.Add(this.buttonReportOutputDB);
            this.Controls.Add(this.buttonAddDataBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseProgram);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDataBase;
        private System.Windows.Forms.Button buttonReportOutputDB;
        private System.Windows.Forms.Button buttonAddFieldDB;
        private System.Windows.Forms.Button buttonEditDB;
        private System.Windows.Forms.Button buttonDeleteDB;
        private System.Windows.Forms.Button buttonSearchFieldDB;
        private System.Windows.Forms.Button buttonReport100InPack;
        private System.Windows.Forms.Button buttonDeleteExpired;
        private System.Windows.Forms.Button buttonReportProductsInPharmacy;
        private System.Windows.Forms.Button buttonReportPriceList;
    }
}

