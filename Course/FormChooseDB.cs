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
    public partial class FormChooseDB : Form
    {
        Form opener;
        public FileStream fs;
        public FormDBAddData frm;


        public FormChooseDB(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void FormChooseDB_Load(object sender, EventArgs e) { }

        private void buttonOpenDB_Click(object sender, EventArgs e)
        {

            FileDB.filePath = textBoxFilePath.Text;
            if (FileDB.CheckIfFileExist())
            {
                panelDBExist.Visible = true;
            }
            else
            {
                FileDB.OpenWriteFile();
                OpenForm();
            }

        }

        private void buttonDBRewrite_Click(object sender, EventArgs e)
        {
            FileDB.OpenAndRewriteFile();
            OpenForm();
        }

        private void buttonDBAddUp_Click(object sender, EventArgs e)
        {
            FileDB.OpenAndAddUpFile();
            OpenForm();
        }

        void OpenForm ()
        {
            FormDBAddData frm = new FormDBAddData();
            frm.Show();
            this.Hide();
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
