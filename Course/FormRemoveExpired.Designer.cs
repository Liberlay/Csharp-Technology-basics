namespace Course
{
    partial class FormRemoveExpired
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
            this.textBoxRemoveExpired = new System.Windows.Forms.TextBox();
            this.buttonRemoveExpired = new System.Windows.Forms.Button();
            this.labelRemoveExpired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите путь к базе данных, например (D:\\pharmacy)";
            // 
            // textBoxRemoveExpired
            // 
            this.textBoxRemoveExpired.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxRemoveExpired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRemoveExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRemoveExpired.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxRemoveExpired.Location = new System.Drawing.Point(160, 75);
            this.textBoxRemoveExpired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRemoveExpired.Name = "textBoxRemoveExpired";
            this.textBoxRemoveExpired.Size = new System.Drawing.Size(311, 30);
            this.textBoxRemoveExpired.TabIndex = 1;
            // 
            // buttonRemoveExpired
            // 
            this.buttonRemoveExpired.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRemoveExpired.FlatAppearance.BorderSize = 0;
            this.buttonRemoveExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRemoveExpired.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRemoveExpired.Location = new System.Drawing.Point(160, 133);
            this.buttonRemoveExpired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveExpired.Name = "buttonRemoveExpired";
            this.buttonRemoveExpired.Size = new System.Drawing.Size(311, 52);
            this.buttonRemoveExpired.TabIndex = 2;
            this.buttonRemoveExpired.Text = "Удалить просроченные";
            this.buttonRemoveExpired.UseVisualStyleBackColor = false;
            this.buttonRemoveExpired.Click += new System.EventHandler(this.buttonRemoveExpired_Click);
            // 
            // labelRemoveExpired
            // 
            this.labelRemoveExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRemoveExpired.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRemoveExpired.Location = new System.Drawing.Point(47, 209);
            this.labelRemoveExpired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemoveExpired.Name = "labelRemoveExpired";
            this.labelRemoveExpired.Size = new System.Drawing.Size(541, 74);
            this.labelRemoveExpired.TabIndex = 3;
            this.labelRemoveExpired.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormRemoveExpired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(632, 306);
            this.Controls.Add(this.labelRemoveExpired);
            this.Controls.Add(this.buttonRemoveExpired);
            this.Controls.Add(this.textBoxRemoveExpired);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRemoveExpired";
            this.Text = "FormRemoveExpired";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRemoveExpired;
        private System.Windows.Forms.Button buttonRemoveExpired;
        private System.Windows.Forms.Label labelRemoveExpired;
    }
}