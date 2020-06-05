namespace Course
{
    partial class FormPassword
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonDBPassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelError.ForeColor = System.Drawing.SystemColors.Window;
            this.labelError.Location = new System.Drawing.Point(95, 162);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(410, 20);
            this.labelError.TabIndex = 16;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDBPassword
            // 
            this.buttonDBPassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDBPassword.FlatAppearance.BorderSize = 0;
            this.buttonDBPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDBPassword.Location = new System.Drawing.Point(250, 107);
            this.buttonDBPassword.Name = "buttonDBPassword";
            this.buttonDBPassword.Size = new System.Drawing.Size(100, 32);
            this.buttonDBPassword.TabIndex = 15;
            this.buttonDBPassword.Text = "Далее";
            this.buttonDBPassword.UseVisualStyleBackColor = false;
            this.buttonDBPassword.Click += new System.EventHandler(this.buttonDBPassword_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.Location = new System.Drawing.Point(206, 57);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(0, 30);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(192, 19);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите пароль для авторизации ";
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(600, 203);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonDBPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPassword";
            this.Text = "FormPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseProgram);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDBPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
    }
}