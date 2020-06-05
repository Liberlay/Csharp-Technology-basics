namespace Course
{
    partial class FormChooseExistDB
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
            this.buttonOpenDB = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenDB
            // 
            this.buttonOpenDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenDB.FlatAppearance.BorderSize = 0;
            this.buttonOpenDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOpenDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenDB.Location = new System.Drawing.Point(365, 146);
            this.buttonOpenDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenDB.Name = "buttonOpenDB";
            this.buttonOpenDB.Size = new System.Drawing.Size(133, 39);
            this.buttonOpenDB.TabIndex = 5;
            this.buttonOpenDB.Text = "Далее";
            this.buttonOpenDB.UseVisualStyleBackColor = false;
            this.buttonOpenDB.Click += new System.EventHandler(this.buttonOpenDB_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Location = new System.Drawing.Point(307, 84);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.textBoxFilePath.MinimumSize = new System.Drawing.Size(0, 30);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(256, 30);
            this.textBoxFilePath.TabIndex = 4;
            this.textBoxFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(159, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите путь к базе данных, например (D:\\pharmacy)";
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelError.ForeColor = System.Drawing.SystemColors.Window;
            this.labelError.Location = new System.Drawing.Point(159, 213);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(547, 25);
            this.labelError.TabIndex = 12;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormChooseExistDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(857, 271);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonOpenDB);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChooseExistDB";
            this.Text = "FormChooseExistDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDB;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
    }
}