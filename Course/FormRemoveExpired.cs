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
    public partial class FormRemoveExpired : Form
    {
        Pharmacy[] pharmacies = new Pharmacy[0];
        public FormRemoveExpired()
        {
            InitializeComponent();
        }

        private async void buttonRemoveExpired_Click(object sender, EventArgs e)
        {
            labelRemoveExpired.Text = String.Empty;
            FileDB.filePath = textBoxRemoveExpired.Text;

            if (FileDB.CheckIfFileExist())
            {
                FileDB.OpenReadFile();
                BinaryReader br = new BinaryReader(FileDB.fs, Encoding.UTF8);
                int count = 0;

                while (br.PeekChar() > -1)
                {
                    Array.Resize(ref pharmacies, pharmacies.Length + 1);
                    pharmacies[count] = new Pharmacy(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), DateTime.Parse(br.ReadString()));
                    count++;
                }
                br.Close();

                Pharmacy[] pharmacyNew = new Pharmacy[0];

                foreach (Pharmacy p in pharmacies)
                {
                    if(!p.CheckIfExpired())
                    {
                        Array.Resize(ref pharmacyNew, pharmacyNew.Length + 1);
                        pharmacyNew[pharmacyNew.Length-1] = p;
                    }
                }
                FileDB.CloseFile();
                FileDB.OpenAndRewriteFile();

                BinaryWriter bw = new BinaryWriter(FileDB.fs, Encoding.UTF8);

                foreach (Pharmacy p in pharmacyNew)
                {
                    bw.Write(p.Name);
                    bw.Write(p.Manufacturer);
                    bw.Write(p.Price);
                    bw.Write(p.Amount);
                    bw.Write(p.PharmNumber);
                    bw.Write(p.DateExpired.ToString());
                }
                bw.Close();
                FileDB.CloseFile();
                await Task.Delay(200);
                labelRemoveExpired.Text = "Просроченые товары были успешно удалены. Удалено " + (pharmacies.Length - pharmacyNew.Length) + " товара(-ов)";

            }
            else
            {
                await Task.Delay(200);
                labelRemoveExpired.Text = "Указанная база данных не существует!";
            }
        }

        private void OpenMainForm(object sender, FormClosedEventArgs e)
        {
            Program.OpenMainForm();
        }
    }
}
