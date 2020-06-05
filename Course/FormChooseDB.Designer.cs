namespace Course
{
    partial class FormChooseDB
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
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenDB = new System.Windows.Forms.Button();
            this.panelDBExist = new System.Windows.Forms.Panel();
            this.buttonDBAddUp = new System.Windows.Forms.Button();
            this.buttonDBRewrite = new System.Windows.Forms.Button();
            this.labelChooseDBExist = new System.Windows.Forms.Label();
            this.panelDBExist.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите путь к базе данных, например (D:\\pharmacy)";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Location = new System.Drawing.Point(197, 86);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.textBoxFilePath.MinimumSize = new System.Drawing.Size(0, 30);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(256, 30);
            this.textBoxFilePath.TabIndex = 1;
            this.textBoxFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOpenDB
            // 
            this.buttonOpenDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenDB.FlatAppearance.BorderSize = 0;
            this.buttonOpenDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOpenDB.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenDB.Location = new System.Drawing.Point(256, 149);
            this.buttonOpenDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenDB.Name = "buttonOpenDB";
            this.buttonOpenDB.Size = new System.Drawing.Size(133, 39);
            this.buttonOpenDB.TabIndex = 2;
            this.buttonOpenDB.Text = "Далее";
            this.buttonOpenDB.UseVisualStyleBackColor = false;
            this.buttonOpenDB.Click += new System.EventHandler(this.buttonOpenDB_Click);
            // 
            // panelDBExist
            // 
            this.panelDBExist.Controls.Add(this.buttonDBAddUp);
            this.panelDBExist.Controls.Add(this.buttonDBRewrite);
            this.panelDBExist.Controls.Add(this.labelChooseDBExist);
            this.panelDBExist.Location = new System.Drawing.Point(23, 224);
            this.panelDBExist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDBExist.Name = "panelDBExist";
            this.panelDBExist.Size = new System.Drawing.Size(616, 187);
            this.panelDBExist.TabIndex = 3;
            this.panelDBExist.Visible = false;
            // 
            // buttonDBAddUp
            // 
            this.buttonDBAddUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDBAddUp.FlatAppearance.BorderSize = 0;
            this.buttonDBAddUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBAddUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBAddUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDBAddUp.Location = new System.Drawing.Point(320, 110);
            this.buttonDBAddUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDBAddUp.Name = "buttonDBAddUp";
            this.buttonDBAddUp.Size = new System.Drawing.Size(179, 37);
            this.buttonDBAddUp.TabIndex = 2;
            this.buttonDBAddUp.Text = "Дозаписать";
            this.buttonDBAddUp.UseVisualStyleBackColor = false;
            this.buttonDBAddUp.Click += new System.EventHandler(this.buttonDBAddUp_Click);
            // 
            // buttonDBRewrite
            // 
            this.buttonDBRewrite.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDBRewrite.FlatAppearance.BorderSize = 0;
            this.buttonDBRewrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBRewrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBRewrite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDBRewrite.Location = new System.Drawing.Point(96, 110);
            this.buttonDBRewrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDBRewrite.Name = "buttonDBRewrite";
            this.buttonDBRewrite.Size = new System.Drawing.Size(179, 37);
            this.buttonDBRewrite.TabIndex = 1;
            this.buttonDBRewrite.Text = "Перезаписать";
            this.buttonDBRewrite.UseVisualStyleBackColor = false;
            this.buttonDBRewrite.Click += new System.EventHandler(this.buttonDBRewrite_Click);
            // 
            // labelChooseDBExist
            // 
            this.labelChooseDBExist.AutoSize = true;
            this.labelChooseDBExist.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseDBExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelChooseDBExist.ForeColor = System.Drawing.SystemColors.Control;
            this.labelChooseDBExist.Location = new System.Drawing.Point(91, 25);
            this.labelChooseDBExist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseDBExist.Name = "labelChooseDBExist";
            this.labelChooseDBExist.Size = new System.Drawing.Size(380, 50);
            this.labelChooseDBExist.TabIndex = 0;
            this.labelChooseDBExist.Text = "Указаная база данных уже существует.\r\nВыберете что с ней сделать.";
            this.labelChooseDBExist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormChooseDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(655, 432);
            this.Controls.Add(this.panelDBExist);
            this.Controls.Add(this.buttonOpenDB);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChooseDB";
            this.Text = "Далее";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            this.Load += new System.EventHandler(this.FormChooseDB_Load);
            this.panelDBExist.ResumeLayout(false);
            this.panelDBExist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonOpenDB;
        private System.Windows.Forms.Panel panelDBExist;
        private System.Windows.Forms.Button buttonDBAddUp;
        private System.Windows.Forms.Button buttonDBRewrite;
        private System.Windows.Forms.Label labelChooseDBExist;
    }
}