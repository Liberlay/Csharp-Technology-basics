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
    public partial class FormProductsInPharmacy : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];
        public FormProductsInPharmacy()
        {
            InitializeComponent();
        }

        private async void buttonOutputDBProductsInPharmacy_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            if (textBoxPharmNumber.Text == "")
            {
                await Task.Delay(200);
                labelError.Text = "Поле не должно быть пустым";
            }
            else
            {
                dataGridViewDBProductsInPharmacy.Rows.Clear();
                FileDB.OpenReadFile();
                BinaryReader br = new BinaryReader(FileDB.fs, Encoding.UTF8);
                int count = 0;
                int rows = 0;

                while (br.PeekChar() > -1)
                {
                    Array.Resize(ref pharmacies, pharmacies.Length + 1);
                    pharmacies[count] = new Pharmacy(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), DateTime.Parse(br.ReadString()));

                    if (Convert.ToInt32(textBoxPharmNumber.Text) == pharmacies[count].PharmNumber)
                    {
                        this.dataGridViewDBProductsInPharmacy.Rows.Insert(rows, pharmacies[count].Name, pharmacies[count].Manufacturer, pharmacies[count].Price, pharmacies[count].Amount, pharmacies[count].PharmNumber, pharmacies[count].DateExpired);
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
