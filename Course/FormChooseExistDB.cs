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
    public partial class FormChooseExistDB : Form
    {
        public FormChooseExistDB()
        {
            InitializeComponent();
        }

        private async void buttonOpenDB_Click(object sender, EventArgs e)
        {
            labelError.Text = String.Empty;
            FileDB.filePath = textBoxFilePath.Text;

            if (FileDB.CheckIfFileExist())
            {
                FileDB.OpenAndAddUpFile();
                FormDBAddData frm1 = new FormDBAddData();
                frm1.Show();
                this.Hide();
            }
            else
            {
                await Task.Delay(200);
                labelError.Text = "Указанная база данных не существует!";
            }
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
