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
    public partial class FormChooseReadDB : Form
    {
        String target;
        public FormChooseReadDB(String eventTarget)
        {
            target = eventTarget;
            InitializeComponent();
        }

        private async void buttonOpenDB_Click(object sender, EventArgs e)
        {
            labelError.Text = String.Empty;
            FileDB.filePath = textBoxFilePath.Text;

            if (FileDB.CheckIfFileExist())
            {
                FileDB.OpenReadFile();
                if (target.Equals("name")) {
                    KeySearchDB frm1 = new KeySearchDB();
                    frm1.Show();
                }
                if (target.Equals("pharmacy"))
                {
                    FormProductsInPharmacy frm1 = new FormProductsInPharmacy();
                    frm1.Show();
                }
                if (target.Equals("edit"))
                {
                    FormEditDB frm1 = new FormEditDB();
                    frm1.Show();
                }
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
