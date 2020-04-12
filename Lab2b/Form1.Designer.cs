namespace Lab2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxCountPyramids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountSquares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAvarageSquare = new System.Windows.Forms.Label();
            this.labelMinimalPyramidSquare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(217)))));
            this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.buttonCalculate.Location = new System.Drawing.Point(356, 19);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 41);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseMnemonic = false;
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCountPyramids
            // 
            this.textBoxCountPyramids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCountPyramids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCountPyramids.Location = new System.Drawing.Point(229, 49);
            this.textBoxCountPyramids.Name = "textBoxCountPyramids";
            this.textBoxCountPyramids.Size = new System.Drawing.Size(100, 19);
            this.textBoxCountPyramids.TabIndex = 1;
            this.textBoxCountPyramids.TextChanged += new System.EventHandler(this.textBoxCountPyramids_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter count of squares:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxInfo.Location = new System.Drawing.Point(16, 88);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(313, 301);
            this.richTextBoxInfo.TabIndex = 4;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBoxInfo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter count of pyramids:";
            // 
            // textBoxCountSquares
            // 
            this.textBoxCountSquares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCountSquares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCountSquares.Location = new System.Drawing.Point(229, 12);
            this.textBoxCountSquares.Name = "textBoxCountSquares";
            this.textBoxCountSquares.Size = new System.Drawing.Size(100, 19);
            this.textBoxCountSquares.TabIndex = 6;
            this.textBoxCountSquares.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(352, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average square of squares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(352, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minimal pyramid square:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelAvarageSquare
            // 
            this.labelAvarageSquare.AutoSize = true;
            this.labelAvarageSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAvarageSquare.ForeColor = System.Drawing.Color.White;
            this.labelAvarageSquare.Location = new System.Drawing.Point(609, 93);
            this.labelAvarageSquare.Name = "labelAvarageSquare";
            this.labelAvarageSquare.Size = new System.Drawing.Size(0, 20);
            this.labelAvarageSquare.TabIndex = 9;
            // 
            // labelMinimalPyramidSquare
            // 
            this.labelMinimalPyramidSquare.AutoSize = true;
            this.labelMinimalPyramidSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMinimalPyramidSquare.ForeColor = System.Drawing.Color.White;
            this.labelMinimalPyramidSquare.Location = new System.Drawing.Point(609, 130);
            this.labelMinimalPyramidSquare.Name = "labelMinimalPyramidSquare";
            this.labelMinimalPyramidSquare.Size = new System.Drawing.Size(0, 20);
            this.labelMinimalPyramidSquare.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.labelMinimalPyramidSquare);
            this.Controls.Add(this.labelAvarageSquare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCountSquares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCountPyramids);
            this.Controls.Add(this.buttonCalculate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxCountPyramids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountSquares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAvarageSquare;
        private System.Windows.Forms.Label labelMinimalPyramidSquare;
    }
}

