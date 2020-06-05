namespace Course
{
    partial class FormEditDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxManufacture = new System.Windows.Forms.TextBox();
            this.textBoxPriceForOne = new System.Windows.Forms.TextBox();
            this.textBoxAmountInPack = new System.Windows.Forms.TextBox();
            this.textBoxPharmNumber = new System.Windows.Forms.TextBox();
            this.labelValidationError1 = new System.Windows.Forms.Label();
            this.labelValidationError2 = new System.Windows.Forms.Label();
            this.labelValidationError3 = new System.Windows.Forms.Label();
            this.labelValidationError4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSuccessAdd = new System.Windows.Forms.Label();
            this.dateTimePickerDateExpired = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDBEditSearch = new System.Windows.Forms.TextBox();
            this.buttonEditDBChange = new System.Windows.Forms.Button();
            this.panelEditDB = new System.Windows.Forms.Panel();
            this.buttonEditDBCancel = new System.Windows.Forms.Button();
            this.buttonEditDBApply = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelEditDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование препарата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фирма-изготовитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена за единицу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество единиц в упаковке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер аптеки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Срок годности";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxProductName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductName.Location = new System.Drawing.Point(265, 6);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(168, 26);
            this.textBoxProductName.TabIndex = 6;
            // 
            // textBoxManufacture
            // 
            this.textBoxManufacture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxManufacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxManufacture.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxManufacture.Location = new System.Drawing.Point(265, 48);
            this.textBoxManufacture.Name = "textBoxManufacture";
            this.textBoxManufacture.Size = new System.Drawing.Size(168, 26);
            this.textBoxManufacture.TabIndex = 7;
            // 
            // textBoxPriceForOne
            // 
            this.textBoxPriceForOne.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPriceForOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceForOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPriceForOne.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPriceForOne.Location = new System.Drawing.Point(265, 89);
            this.textBoxPriceForOne.Name = "textBoxPriceForOne";
            this.textBoxPriceForOne.Size = new System.Drawing.Size(168, 26);
            this.textBoxPriceForOne.TabIndex = 8;
            // 
            // textBoxAmountInPack
            // 
            this.textBoxAmountInPack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxAmountInPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmountInPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAmountInPack.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxAmountInPack.Location = new System.Drawing.Point(265, 135);
            this.textBoxAmountInPack.Name = "textBoxAmountInPack";
            this.textBoxAmountInPack.Size = new System.Drawing.Size(168, 26);
            this.textBoxAmountInPack.TabIndex = 9;
            // 
            // textBoxPharmNumber
            // 
            this.textBoxPharmNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPharmNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPharmNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPharmNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPharmNumber.Location = new System.Drawing.Point(265, 181);
            this.textBoxPharmNumber.Name = "textBoxPharmNumber";
            this.textBoxPharmNumber.Size = new System.Drawing.Size(168, 26);
            this.textBoxPharmNumber.TabIndex = 10;
            // 
            // labelValidationError1
            // 
            this.labelValidationError1.AutoSize = true;
            this.labelValidationError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError1.ForeColor = System.Drawing.SystemColors.Window;
            this.labelValidationError1.Location = new System.Drawing.Point(467, 8);
            this.labelValidationError1.Name = "labelValidationError1";
            this.labelValidationError1.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError1.TabIndex = 12;
            // 
            // labelValidationError2
            // 
            this.labelValidationError2.AutoSize = true;
            this.labelValidationError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError2.ForeColor = System.Drawing.SystemColors.Window;
            this.labelValidationError2.Location = new System.Drawing.Point(467, 50);
            this.labelValidationError2.Name = "labelValidationError2";
            this.labelValidationError2.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError2.TabIndex = 13;
            // 
            // labelValidationError3
            // 
            this.labelValidationError3.AutoSize = true;
            this.labelValidationError3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError3.ForeColor = System.Drawing.SystemColors.Window;
            this.labelValidationError3.Location = new System.Drawing.Point(467, 91);
            this.labelValidationError3.Name = "labelValidationError3";
            this.labelValidationError3.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError3.TabIndex = 14;
            // 
            // labelValidationError4
            // 
            this.labelValidationError4.AutoSize = true;
            this.labelValidationError4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValidationError4.ForeColor = System.Drawing.SystemColors.Window;
            this.labelValidationError4.Location = new System.Drawing.Point(467, 137);
            this.labelValidationError4.Name = "labelValidationError4";
            this.labelValidationError4.Size = new System.Drawing.Size(0, 20);
            this.labelValidationError4.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(467, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 16;
            // 
            // labelSuccessAdd
            // 
            this.labelSuccessAdd.AutoSize = true;
            this.labelSuccessAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSuccessAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSuccessAdd.Location = new System.Drawing.Point(450, 298);
            this.labelSuccessAdd.Name = "labelSuccessAdd";
            this.labelSuccessAdd.Size = new System.Drawing.Size(0, 20);
            this.labelSuccessAdd.TabIndex = 17;
            // 
            // dateTimePickerDateExpired
            // 
            this.dateTimePickerDateExpired.Location = new System.Drawing.Point(265, 223);
            this.dateTimePickerDateExpired.Name = "dateTimePickerDateExpired";
            this.dateTimePickerDateExpired.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerDateExpired.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Введите название препарата:";
            // 
            // textBoxDBEditSearch
            // 
            this.textBoxDBEditSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxDBEditSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDBEditSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDBEditSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDBEditSearch.Location = new System.Drawing.Point(16, 42);
            this.textBoxDBEditSearch.Name = "textBoxDBEditSearch";
            this.textBoxDBEditSearch.Size = new System.Drawing.Size(132, 26);
            this.textBoxDBEditSearch.TabIndex = 20;
            // 
            // buttonEditDBChange
            // 
            this.buttonEditDBChange.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditDBChange.FlatAppearance.BorderSize = 0;
            this.buttonEditDBChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDBChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditDBChange.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEditDBChange.Location = new System.Drawing.Point(16, 78);
            this.buttonEditDBChange.Name = "buttonEditDBChange";
            this.buttonEditDBChange.Size = new System.Drawing.Size(107, 31);
            this.buttonEditDBChange.TabIndex = 21;
            this.buttonEditDBChange.Text = "Изменить";
            this.buttonEditDBChange.UseVisualStyleBackColor = false;
            this.buttonEditDBChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelEditDB
            // 
            this.panelEditDB.Controls.Add(this.label2);
            this.panelEditDB.Controls.Add(this.label1);
            this.panelEditDB.Controls.Add(this.label3);
            this.panelEditDB.Controls.Add(this.label4);
            this.panelEditDB.Controls.Add(this.dateTimePickerDateExpired);
            this.panelEditDB.Controls.Add(this.label5);
            this.panelEditDB.Controls.Add(this.labelSuccessAdd);
            this.panelEditDB.Controls.Add(this.label6);
            this.panelEditDB.Controls.Add(this.label11);
            this.panelEditDB.Controls.Add(this.textBoxProductName);
            this.panelEditDB.Controls.Add(this.labelValidationError4);
            this.panelEditDB.Controls.Add(this.textBoxManufacture);
            this.panelEditDB.Controls.Add(this.labelValidationError3);
            this.panelEditDB.Controls.Add(this.textBoxPriceForOne);
            this.panelEditDB.Controls.Add(this.labelValidationError2);
            this.panelEditDB.Controls.Add(this.textBoxAmountInPack);
            this.panelEditDB.Controls.Add(this.labelValidationError1);
            this.panelEditDB.Controls.Add(this.textBoxPharmNumber);
            this.panelEditDB.Location = new System.Drawing.Point(16, 136);
            this.panelEditDB.Name = "panelEditDB";
            this.panelEditDB.Size = new System.Drawing.Size(777, 336);
            this.panelEditDB.TabIndex = 22;
            this.panelEditDB.Visible = false;
            // 
            // buttonEditDBCancel
            // 
            this.buttonEditDBCancel.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonEditDBCancel.FlatAppearance.BorderSize = 0;
            this.buttonEditDBCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDBCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditDBCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEditDBCancel.Location = new System.Drawing.Point(23, 426);
            this.buttonEditDBCancel.Name = "buttonEditDBCancel";
            this.buttonEditDBCancel.Size = new System.Drawing.Size(212, 38);
            this.buttonEditDBCancel.TabIndex = 23;
            this.buttonEditDBCancel.Text = "Завершить изменение";
            this.buttonEditDBCancel.UseVisualStyleBackColor = false;
            this.buttonEditDBCancel.Click += new System.EventHandler(this.buttonEditDBCancel_Click);
            // 
            // buttonEditDBApply
            // 
            this.buttonEditDBApply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditDBApply.FlatAppearance.BorderSize = 0;
            this.buttonEditDBApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDBApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditDBApply.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEditDBApply.Location = new System.Drawing.Point(302, 425);
            this.buttonEditDBApply.Name = "buttonEditDBApply";
            this.buttonEditDBApply.Size = new System.Drawing.Size(146, 39);
            this.buttonEditDBApply.TabIndex = 24;
            this.buttonEditDBApply.Text = "Применить";
            this.buttonEditDBApply.UseVisualStyleBackColor = false;
            this.buttonEditDBApply.Click += new System.EventHandler(this.buttonEditDBApply_Click);
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelError.ForeColor = System.Drawing.SystemColors.Window;
            this.labelError.Location = new System.Drawing.Point(12, 112);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(436, 23);
            this.labelError.TabIndex = 25;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEditDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(796, 484);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonEditDBApply);
            this.Controls.Add(this.buttonEditDBCancel);
            this.Controls.Add(this.panelEditDB);
            this.Controls.Add(this.buttonEditDBChange);
            this.Controls.Add(this.textBoxDBEditSearch);
            this.Controls.Add(this.label13);
            this.Name = "FormEditDB";
            this.Text = "FormEditDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            this.panelEditDB.ResumeLayout(false);
            this.panelEditDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxManufacture;
        private System.Windows.Forms.TextBox textBoxPriceForOne;
        private System.Windows.Forms.TextBox textBoxAmountInPack;
        private System.Windows.Forms.TextBox textBoxPharmNumber;
        private System.Windows.Forms.Label labelValidationError1;
        private System.Windows.Forms.Label labelValidationError2;
        private System.Windows.Forms.Label labelValidationError3;
        private System.Windows.Forms.Label labelValidationError4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSuccessAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExpired;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDBEditSearch;
        private System.Windows.Forms.Button buttonEditDBChange;
        private System.Windows.Forms.Panel panelEditDB;
        private System.Windows.Forms.Button buttonEditDBCancel;
        private System.Windows.Forms.Button buttonEditDBApply;
        private System.Windows.Forms.Label labelError;
    }
}