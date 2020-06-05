using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private async void buttonDBPassword_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            if (textBoxPassword.Text == "")
            {
                await Task.Delay(200);
                labelError.Text = "Поле не должно быть пустым";
            }
            else
            { 
                if (textBoxPassword.Text.Equals("0000"))
                {
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }

                else
                {
                    await Task.Delay(200);
                    labelError.Text = "Введеный пароль неверный";
                }
            }
        }

        private void CloseProgram(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
