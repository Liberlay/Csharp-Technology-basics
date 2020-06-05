namespace Course
{
    partial class FormDBAddData
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
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonAddBreak = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxManufacture = new System.Windows.Forms.TextBox();
            this.textBoxPriceForOne = new System.Windows.Forms.TextBox();
            this.textBoxAmountInPack = new System.Windows.Forms.TextBox();
            this.textBoxPharmNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerExpired = new System.Windows.Forms.DateTimePicker();
            this.labelValidationError2 = new System.Windows.Forms.Label();
            this.labelValidationError3 = new System.Windows.Forms.Label();
            this.labelValidationError4 = new System.Windows.Forms.Label();
            this.labelValidationError1 = new System.Windows.Forms.Label();
            this.labelSuccessAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddData
            // 
            this.buttonAddData.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddData.FlatAppearance.BorderSize = 0;
            this.buttonAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddData.Location = new System.Drawing.Point(274, 371);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(163, 31);
            this.buttonAddData.TabIndex = 0;
            this.buttonAddData.Text = "Добавить запись";
            this.buttonAddData.UseVisualStyleBackColor = false;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonAddBreak
            // 
            this.buttonAddBreak.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonAddBreak.FlatAppearance.BorderSize = 0;
            this.buttonAddBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddBreak.Location = new System.Drawing.Point(16, 371);
            this.buttonAddBreak.Name = "buttonAddBreak";
            this.buttonAddBreak.Size = new System.Drawing.Size(129, 31);
            this.buttonAddBreak.TabIndex = 1;
            this.buttonAddBreak.Text = "Прервать заполнение";
            this.buttonAddBreak.UseVisualStyleBackColor = false;
            this.buttonAddBreak.Click += new System.EventHandler(this.buttonAddBreak_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxProductName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductName.Location = new System.Drawing.Point(274, 24);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(163, 26);
            this.textBoxProductName.TabIndex = 6;
            // 
            // textBoxManufacture
            // 
            this.textBoxManufacture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxManufacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxManufacture.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxManufacture.Location = new System.Drawing.Point(274, 77);
            this.textBoxManufacture.Name = "textBoxManufacture";
            this.textBoxManufacture.Size = new System.Drawing.Size(163, 26);
            this.textBoxManufacture.TabIndex = 7;
            // 
            // textBoxPriceForOne
            // 
            this.textBoxPriceForOne.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPriceForOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceForOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPriceForOne.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPriceForOne.Location = new System.Drawing.Point(274, 130);
            this.textBoxPriceForOne.Name = "textBoxPriceForOne";
            this.textBoxPriceForOne.Size = new System.Drawing.Size(163, 26);
            this.textBoxPriceForOne.TabIndex = 8;
            // 
            // textBoxAmountInPack
            // 
            this.textBoxAmountInPack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxAmountInPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountInPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAmountInPack.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxAmountInPack.Location = new System.Drawing.Point(274, 189);
            this.textBoxAmountInPack.Name = "textBoxAmountInPack";
            this.textBoxAmountInPack.Size = new System.Drawing.Size(163, 26);
            this.textBoxAmountInPack.TabIndex = 9;
            // 
            // textBoxPharmNumber
            // 
            this.textBoxPharmNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPharmNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPharmNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPharmNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPharmNumber.Location = new System.Drawing.Point(274, 246);
            this.textBoxPharmNumber.Name = "textBoxPharmNumber";
            this.textBoxPharmNumber.Size = new System.Drawing.Size(163, 26);
            this.textBoxPharmNumber.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Наименование препарата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фирма-изготовитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Цена за единицу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество единиц в упаковке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер аптеки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Срок годности";
            // 
            // dateTimePickerExpired
            // 
            this.dateTimePickerExpired.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerExpired.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dateTimePickerExpired.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dateTimePickerExpired.Location = new System.Drawing.Point(274, 297);
            this.dateTimePickerExpired.Name = "dateTimePickerExpired";
            this.dateTimePickerExpired.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerExpired.TabIndex = 18;
            // 
            // labelValidationError2
            // 
            this.labelValidationError2.AutoSize = true;
            this.labelValidationError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError2.Location = new System.Drawing.Point(461, 132);
            this.labelValidationError2.Name = "labelValidationError2";
            this.labelValidationError2.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError2.TabIndex = 19;
            // 
            // labelValidationError3
            // 
            this.labelValidationError3.AutoSize = true;
            this.labelValidationError3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError3.Location = new System.Drawing.Point(461, 195);
            this.labelValidationError3.Name = "labelValidationError3";
            this.labelValidationError3.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError3.TabIndex = 22;
            // 
            // labelValidationError4
            // 
            this.labelValidationError4.AutoSize = true;
            this.labelValidationError4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError4.Location = new System.Drawing.Point(461, 252);
            this.labelValidationError4.Name = "labelValidationError4";
            this.labelValidationError4.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError4.TabIndex = 23;
            // 
            // labelValidationError1
            // 
            this.labelValidationError1.AutoSize = true;
            this.labelValidationError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError1.Location = new System.Drawing.Point(461, 29);
            this.labelValidationError1.Name = "labelValidationError1";
            this.labelValidationError1.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError1.TabIndex = 20;
            // 
            // labelSuccessAdd
            // 
            this.labelSuccessAdd.AutoSize = true;
            this.labelSuccessAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSuccessAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelSuccessAdd.Location = new System.Drawing.Point(461, 376);
            this.labelSuccessAdd.Name = "labelSuccessAdd";
            this.labelSuccessAdd.Size = new System.Drawing.Size(0, 20);
            this.labelSuccessAdd.TabIndex = 24;
            // 
            // FormDBAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSuccessAdd);
            this.Controls.Add(this.labelValidationError4);
            this.Controls.Add(this.labelValidationError3);
            this.Controls.Add(this.labelValidationError1);
            this.Controls.Add(this.labelValidationError2);
            this.Controls.Add(this.dateTimePickerExpired);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPharmNumber);
            this.Controls.Add(this.textBoxAmountInPack);
            this.Controls.Add(this.textBoxPriceForOne);
            this.Controls.Add(this.textBoxManufacture);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonAddBreak);
            this.Controls.Add(this.buttonAddData);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormDBAddData";
            this.Text = "FormDBAddData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonAddBreak;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxManufacture;
        private System.Windows.Forms.TextBox textBoxPriceForOne;
        private System.Windows.Forms.TextBox textBoxAmountInPack;
        private System.Windows.Forms.TextBox textBoxPharmNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpired;
        private System.Windows.Forms.Label labelValidationError2;
        private System.Windows.Forms.Label labelValidationError3;
        private System.Windows.Forms.Label labelValidationError4;
        private System.Windows.Forms.Label labelValidationError1;
        private System.Windows.Forms.Label labelSuccessAdd;
    }
}