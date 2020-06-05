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
    public partial class FormMoreThen100 : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];
        public FormMoreThen100()
        {
            InitializeComponent();
        }

        private async void buttonDBMoreThen100_Click(object sender, EventArgs e)
        {
            labelDBMoreThen100.Text = String.Empty;
            FileDB.filePath = textBoxFilePath.Text;

            if (FileDB.CheckIfFileExist())
            {
                FileDB.OpenReadFile();
                BinaryReader br = new BinaryReader(FileDB.fs, Encoding.UTF8);
                int count = 0;
                int rows = 0;

                while (br.PeekChar() > -1)
                {

                    Array.Resize(ref pharmacies, pharmacies.Length + 1);
                    pharmacies[count] = new Pharmacy(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), DateTime.Parse(br.ReadString()));

                    if (pharmacies[count].Amount > 100) {
                        this.dataGridViewDBMoreThen100.Rows.Insert(rows, pharmacies[count].Name, pharmacies[count].Manufacturer, pharmacies[count].Price, pharmacies[count].Amount, pharmacies[count].PharmNumber, pharmacies[count].DateExpired);
                        rows++;
                    }

                    count++;
                }

                br.Close();
                FileDB.CloseFile();
            }
            else
            {
                await Task.Delay(200);
                labelDBMoreThen100.Text = "Указанная база данных не существует!";
            }
        }

        private void labelDBMoreThen100_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDBMoreThen100_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenMainForm(object sender, FormClosingEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
