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
    public partial class KeySearchDB : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];
        public KeySearchDB()
        {
            InitializeComponent();
        }

        private async void buttonKeySearch_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            if (textBoxNameProduct.Text == "")
            {
                await Task.Delay(200);
                labelError.Text = "Поле не должно быть пустым";
            } else
            {
                dataGridViewDBKeySearch.Rows.Clear();
                FileDB.OpenReadFile();
                BinaryReader br = new BinaryReader(FileDB.fs, Encoding.UTF8);
                int count = 0;
                int rows = 0;

                while (br.PeekChar() > -1)
                {
                    Array.Resize(ref pharmacies, pharmacies.Length + 1);
                    pharmacies[count] = new Pharmacy(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), DateTime.Parse(br.ReadString()));

                    if (textBoxNameProduct.Text.Equals(pharmacies[count].Name))
                    {
                        this.dataGridViewDBKeySearch.Rows.Insert(rows, pharmacies[count].Name, pharmacies[count].Manufacturer, pharmacies[count].Price, pharmacies[count].Amount, pharmacies[count].PharmNumber, pharmacies[count].DateExpired);
                        rows++;
                    }

                    count++;
                }

                if (rows == 0)
                {
                    await Task.Delay(200);
                    labelError.Text = "Указанного товара не существует";
                }

                br.Close();
                FileDB.CloseFile();

            }
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
