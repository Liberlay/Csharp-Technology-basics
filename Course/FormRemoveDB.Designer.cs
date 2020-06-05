namespace Course
{
    partial class FormRemoveDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveDBYes = new System.Windows.Forms.Button();
            this.buttonRemoveDBNo = new System.Windows.Forms.Button();
            this.panelDBRemove = new System.Windows.Forms.Panel();
            this.labelRemoveDBSuccess = new System.Windows.Forms.Label();
            this.buttonDBRemove = new System.Windows.Forms.Button();
            this.labelRemoveDB = new System.Windows.Forms.Label();
            this.panelDBRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(48, 27);
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
            this.textBoxFilePath.Location = new System.Drawing.Point(200, 70);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(215, 30);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(39, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вы точно хотите удалить базу данных? ";
            // 
            // buttonRemoveDBYes
            // 
            this.buttonRemoveDBYes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRemoveDBYes.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRemoveDBYes.FlatAppearance.BorderSize = 0;
            this.buttonRemoveDBYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveDBYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRemoveDBYes.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRemoveDBYes.Location = new System.Drawing.Point(44, 85);
            this.buttonRemoveDBYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveDBYes.Name = "buttonRemoveDBYes";
            this.buttonRemoveDBYes.Size = new System.Drawing.Size(100, 41);
            this.buttonRemoveDBYes.TabIndex = 3;
            this.buttonRemoveDBYes.Text = "Да";
            this.buttonRemoveDBYes.UseVisualStyleBackColor = false;
            this.buttonRemoveDBYes.Click += new System.EventHandler(this.buttonRemoveDBYes_Click);
            // 
            // buttonRemoveDBNo
            // 
            this.buttonRemoveDBNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRemoveDBNo.FlatAppearance.BorderSize = 0;
            this.buttonRemoveDBNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveDBNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRemoveDBNo.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRemoveDBNo.Location = new System.Drawing.Point(357, 85);
            this.buttonRemoveDBNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveDBNo.Name = "buttonRemoveDBNo";
            this.buttonRemoveDBNo.Size = new System.Drawing.Size(100, 41);
            this.buttonRemoveDBNo.TabIndex = 4;
            this.buttonRemoveDBNo.Text = "Нет";
            this.buttonRemoveDBNo.UseVisualStyleBackColor = false;
            this.buttonRemoveDBNo.Click += new System.EventHandler(this.buttonRemoveDBNo_Click);
            // 
            // panelDBRemove
            // 
            this.panelDBRemove.Controls.Add(this.labelRemoveDBSuccess);
            this.panelDBRemove.Controls.Add(this.buttonRemoveDBYes);
            this.panelDBRemove.Controls.Add(this.label2);
            this.panelDBRemove.Controls.Add(this.buttonRemoveDBNo);
            this.panelDBRemove.Location = new System.Drawing.Point(67, 224);
            this.panelDBRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDBRemove.Name = "panelDBRemove";
            this.panelDBRemove.Size = new System.Drawing.Size(485, 187);
            this.panelDBRemove.TabIndex = 5;
            this.panelDBRemove.Visible = false;
            // 
            // labelRemoveDBSuccess
            // 
            this.labelRemoveDBSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRemoveDBSuccess.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRemoveDBSuccess.Location = new System.Drawing.Point(5, 151);
            this.labelRemoveDBSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemoveDBSuccess.Name = "labelRemoveDBSuccess";
            this.labelRemoveDBSuccess.Size = new System.Drawing.Size(480, 28);
            this.labelRemoveDBSuccess.TabIndex = 5;
            this.labelRemoveDBSuccess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDBRemove
            // 
            this.buttonDBRemove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDBRemove.FlatAppearance.BorderSize = 0;
            this.buttonDBRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDBRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDBRemove.Location = new System.Drawing.Point(231, 117);
            this.buttonDBRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDBRemove.Name = "buttonDBRemove";
            this.buttonDBRemove.Size = new System.Drawing.Size(149, 39);
            this.buttonDBRemove.TabIndex = 6;
            this.buttonDBRemove.Text = "Удалить";
            this.buttonDBRemove.UseVisualStyleBackColor = false;
            this.buttonDBRemove.Click += new System.EventHandler(this.buttonDBRemove_Click);
            // 
            // labelRemoveDB
            // 
            this.labelRemoveDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRemoveDB.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRemoveDB.Location = new System.Drawing.Point(67, 182);
            this.labelRemoveDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemoveDB.Name = "labelRemoveDB";
            this.labelRemoveDB.Size = new System.Drawing.Size(485, 25);
            this.labelRemoveDB.TabIndex = 7;
            this.labelRemoveDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormRemoveDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(633, 464);
            this.Controls.Add(this.labelRemoveDB);
            this.Controls.Add(this.buttonDBRemove);
            this.Controls.Add(this.panelDBRemove);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRemoveDB";
            this.Text = "FormRemoveDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenMainForm);
            this.panelDBRemove.ResumeLayout(false);
            this.panelDBRemove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveDBYes;
        private System.Windows.Forms.Button buttonRemoveDBNo;
        private System.Windows.Forms.Panel panelDBRemove;
        private System.Windows.Forms.Button buttonDBRemove;
        private System.Windows.Forms.Label labelRemoveDB;
        private System.Windows.Forms.Label labelRemoveDBSuccess;
    }
}