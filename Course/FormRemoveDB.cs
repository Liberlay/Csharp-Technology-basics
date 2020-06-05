using System;
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
    public partial class FormRemoveDB : Form
    {
        public FormRemoveDB()
        {
            InitializeComponent();
        }

        private async void buttonDBRemove_Click(object sender, EventArgs e)
        {
            labelRemoveDB.Text = String.Empty;
            FileDB.filePath = textBoxFilePath.Text;

            if (FileDB.CheckIfFileExist())
            {
                panelDBRemove.Visible = true;
            }
            else
            {
                await Task.Delay(200);
                labelRemoveDB.Text = "Указанная база данных не существует!";
            }
        }

        private async void buttonRemoveDBYes_Click(object sender, EventArgs e)
        {
            FileDB.DeleteFile();
            labelRemoveDBSuccess.Text = "База данных успешно удалена";
            await Task.Delay(2000);
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void buttonRemoveDBNo_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
