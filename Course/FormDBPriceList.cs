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
    public partial class FormDBPriceList : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];

        public FormDBPriceList()
        {
            InitializeComponent();
        }

        private async void buttonDBPriceList_Click(object sender, EventArgs e)
        {
            labelDBPriceList.Text = String.Empty;
            FileDB.filePath = textBoxFilePath.Text;

            if (FileDB.CheckIfFileExist())
            {
                dataGridViewDBPriceList.Rows.Clear();
                FileDB.OpenReadFile();
                BinaryReader br = new BinaryReader(FileDB.fs, Encoding.UTF8);
                int count = 0;

                while (br.PeekChar() > -1)
                {

                    Array.Resize(ref pharmacies, pharmacies.Length + 1);
                    pharmacies[count] = new Pharmacy(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), DateTime.Parse(br.ReadString()));
                    this.dataGridViewDBPriceList.Rows.Insert(count, pharmacies[count].Name, pharmacies[count].Price, pharmacies[count].Amount, pharmacies[count].Amount * pharmacies[count].Price);

                    count++;
                }


                br.Close();
                FileDB.CloseFile();
            }
            else
            {
                await Task.Delay(200);
                labelDBPriceList.Text = "Указанная база данных не существует!";
            }
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
